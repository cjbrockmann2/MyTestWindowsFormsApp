using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopitosWindowsFormsApp;
using CopitosWindowsFormsApp.Helper;
using CopitosWindowsFormsApp.Model;

namespace CopitosWindowsFormsApp
{
    public partial class Hauptformular : Form
    {
        public Hauptformular()
        {
            InitializeComponent();
            Singleton.InitialStartOfGriddata();
        }

        #region Allgemein 
        // ---------------------------------------------------------------------

        private void Hauptformular_Load(object sender, EventArgs e)
        {
            Singleton.Ergebnisse = new List<Ergebnisse>();
            dataGridViewAusgabe.DataSource = Singleton.Ergebnisse;
            dataGridViewAusgabe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAusgabe.MultiSelect = false;


            Singleton.PersonalStammDaten = (new List<Personalstamm>()).ToDataTable();
            AddProtocolColumnsToDataTable(Singleton.PersonalStammDaten);
            dataGridPersonalstammdaten.DataSource = Singleton.PersonalStammDaten;
            dataGridPersonalstammdaten .SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPersonalstammdaten.MultiSelect = false;

            Singleton.EinkaufsDaten = (new List<Einkaeufe>()).ToDataTable();
            AddProtocolColumnsToDataTable(Singleton.EinkaufsDaten);
            dataGridEinkauf.DataSource = Singleton.EinkaufsDaten;
            dataGridEinkauf.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEinkauf.MultiSelect = false;

            helpSetReadOnlyColumnOnDataGridView(dataGridPersonalstammdaten, new string[1] { "Kartennummer" });
            helpSetReadOnlyColumnOnDataGridView(dataGridEinkauf, new string[2] { "Kartennummer", "Betrag" });


        }



        private void Auswertung()
        {
            
            if (Singleton.PersonalStammDaten != null && Singleton.EinkaufsDaten != null && Singleton.PersonalStammDaten.Rows.Count > 0 && Singleton.EinkaufsDaten.Rows.Count > 0)
            {


                Singleton.PersonalStammDaten.AcceptChanges();
                Singleton.EinkaufsDaten.AcceptChanges();

                var person = Singleton.PersonalStammDaten.DataTableToList<Personalstamm>();
                var einkauf = Singleton.EinkaufsDaten.DataTableToList<Einkaeufe>();
                
                var mergeData = from p in person
                                join k in einkauf
                                on p.Kartennummer.ToUpper() equals k.Kartennummer.ToUpper()
                                select new Ergebnisse
                                {
                                    Name = p.Name                                   ,
                                    Vorname = p.Vorname,
                                    Strasse = p.Strasse,
                                    Hausnummer = p.Hausnummer,
                                    PLZ = p.PLZ,
                                    Ort = p.Ort,
                                    Land = p.Land,
                                    Kartennummer = p.Kartennummer.ToUpper(),
                                    Betrag = k.Betrag

                                };

                Singleton.Ergebnisse = mergeData.ToList();

                dataGridViewAusgabe.DataSource = Singleton.Ergebnisse;
                var ct = dataGridViewAusgabe.ColumnCount;
                foreach (DataGridViewColumn c in dataGridViewAusgabe.Columns)
                {
                    if (c.HeaderText == "Betrag") c.DisplayIndex = ct - 1;
                    else if (c.HeaderText == "USt") c.DisplayIndex = ct - 1;
                }
            } 
            else
            {
                Singleton.Ergebnisse = new List<Ergebnisse>();
                dataGridViewAusgabe.DataSource = Singleton.Ergebnisse;
            }
        }



        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var tab = (TabControl)sender;
            if (tab.TabPages[tab.SelectedIndex].Text == "Ausgabe")
            {
                Auswertung();
                //helpSetReadOnlyColumnOnDataGridView(dataGridPersonalstammdaten, new string[1] { "Kartennummer" });
                //helpSetReadOnlyColumnOnDataGridView(dataGridEinkauf, new string[2] { "Kartennummer", "Betrag" });
            }
        }

        private void datenLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Singleton.PersonalStammDaten != null)
            {
                Singleton.PersonalStammDaten.Clear();
                dataGridPersonalstammdaten.Refresh();
            }
            if (Singleton.EinkaufsDaten != null)
            {
                Singleton.EinkaufsDaten.Clear();
                dataGridEinkauf.Refresh();
            }
            if (Singleton.Ergebnisse != null)
            {
                Singleton.Ergebnisse = new List<Ergebnisse>();
                dataGridViewAusgabe.DataSource = Singleton.Ergebnisse;
            }
        }

        #endregion


        #region Helper-Funktionen
        // ---------------------------------------------------------------------




        private void helpSetReadOnlyColumnOnDataGridView(DataGridView grd, string[] columnList)
        {
            for (int j = 0; j <= grd.NewRowIndex; j++)
            {
                for (int i = 0; i < columnList.Length; i++)
                {
                    try
                    {
                        if (j == grd.NewRowIndex) grd[columnList[i], j].ReadOnly = false;
                        else grd[columnList[i], j].ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

            }
        }

        private void AddProtocolColumnsToDataTable(DataTable dt)
        {
            dt.Columns.Add("NTUser", typeof(string));
            dt.Columns.Add("Timestamp", typeof(DateTime));
        }


        private void CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var oldValue = grid[e.ColumnIndex, e.RowIndex].Value.ToString();
            var newValue = e.FormattedValue.ToString();
            if (oldValue != newValue)
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    row.Cells["NTUser"].Value = DBNull.Value;
                    row.Cells["Timestamp"].Value = DBNull.Value;
                }
                grid.Rows[e.RowIndex].ErrorText = String.Empty;
                grid.Rows[e.RowIndex].Cells["NTUser"].Value = Singleton.LoggedUser;
                grid.Rows[e.RowIndex].Cells["Timestamp"].Value = DateTime.Now;
            }
        }


        #endregion


        #region Personalstamm 
        // ---------------------------------------------------------------------

        private void btnPersonalstammImportieren_Click(object sender, EventArgs e)
        {
            DataTable dt = Einlesen.DatenEinlesen(Singleton.ImportType.xls);
            AddProtocolColumnsToDataTable(dt);
            Singleton.PersonalStammDaten = dt;
            dataGridPersonalstammdaten.DataSource = Singleton.PersonalStammDaten;
            helpSetReadOnlyColumnOnDataGridView(dataGridPersonalstammdaten, new string[1] { "Kartennummer" });
            Auswertung();
        }


        private void dataGridPersonalstammdaten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridPersonalstammdaten.Rows[e.RowIndex].ErrorText = String.Empty;
            Singleton.PersonalStammDaten.AcceptChanges();
        }

        private void dataGridPersonalstammdaten_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            CellValidating(sender, e);
        }

        private void dataGridPersonalstammdaten_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var grid = (DataGridView)sender;
            grid.ClearSelection();
            grid.Rows[e.RowIndex].Selected = true;
        }

 


        #endregion


        #region Einkauf
        // ---------------------------------------------------------------------
        private void btnEinkaeufeImportieren_Click(object sender, EventArgs e)
        {
            DataTable dt = Einlesen.DatenEinlesen(Singleton.ImportType.csv);
            AddProtocolColumnsToDataTable(dt);
            dt = dt.Select("Kartennummer is not null and Kartennummer <> ''").CopyToDataTable();
            Singleton.EinkaufsDaten = dt;
            dataGridEinkauf.DataSource = Singleton.EinkaufsDaten;
            helpSetReadOnlyColumnOnDataGridView(dataGridEinkauf, new string[2] { "Kartennummer", "Betrag" });
            Auswertung();
        }

        private void dataGridEinkauf_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            grid.Rows[e.RowIndex].ErrorText = String.Empty;
            Singleton.EinkaufsDaten.AcceptChanges();
        }

        private void dataGridEinkauf_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var idx = e.ColumnIndex;
            var col = ((DataGridView)sender).Columns[idx];
            if (col.Name == "Betrag" && e.RowIndex < dataGridEinkauf.NewRowIndex)
            {
                string input = e.FormattedValue.ToString();
                try
                {
                    Single result = Convert.ToSingle(input);
                    CellValidating(sender, e);
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    dataGridEinkauf.Rows[e.RowIndex].ErrorText = "Der Betrag muss numerisch sein!";
                }
            }
        }


        private void dataGridEinkauf_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var grid = (DataGridView)sender;
            grid.ClearSelection();
            grid.Rows[e.RowIndex].Selected = true;
        }

        #endregion


    }
}
