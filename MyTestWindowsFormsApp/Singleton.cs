using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopitosWindowsFormsApp.Helper;
using CopitosWindowsFormsApp.Model;
using ExcelDataReader;



namespace CopitosWindowsFormsApp
{
    public static class Singleton
    {
        public enum ImportType
        {
            xls, csv
        }

        //public static IEnumerable<Personalstamm> Personen;

        //public static IEnumerable<Einkaeufe> Einkauf;

        public static IEnumerable<Ergebnisse> Ergebnisse;

        public static DataTable PersonalStammDaten; 

        public static DataTable EinkaufsDaten;

        public static string LoggedUser = string.Empty; 

        public static void InitialStartOfGriddata()
        {
            PersonalStammDaten = (new List<Personalstamm>()).ToDataTable<Personalstamm>();

            EinkaufsDaten = (new List<Einkaeufe>()).ToDataTable<Einkaeufe>();

            Ergebnisse = new List<Ergebnisse>();

        }



    }
}

