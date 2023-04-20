using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CopitosWindowsFormsApp.Singleton;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace CopitosWindowsFormsApp.Helper
{
    public static class Einlesen
    {

        public static DataTable DatenEinlesen(ImportType importtype)
        {
            string fileName = string.Empty;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.InitialDirectory = ConfigurationManager.AppSettings["Path"];
            DataTable dt = null;
            if (importtype == ImportType.csv)
            {
                theDialog.Title = "Open CSV File";
                theDialog.Filter = "CSV files|*.csv";
            }
            else
            {
                theDialog.Title = "Open Excel File";
                theDialog.Filter = "XLS files|*.xls";
            }


            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = theDialog.FileName.ToString();
                if (!string.IsNullOrEmpty(fileName)) dt = MyReader.ReadExcel(fileName);

            }

            return dt;
        }


    }
}
