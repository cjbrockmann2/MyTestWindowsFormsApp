using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopitosWindowsFormsApp.Helper
{
    public static class MyReader
    {


        public static DataTable ReadExcel(string filePath)
        {
            DataTable dataTable = new DataTable();
            if (!string.IsNullOrEmpty(filePath))
            {

                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                IExcelDataReader excelReader;

                //1. Reading Excel file
                if (Path.GetExtension(filePath).ToUpper() == ".XLS")
                {
                    //1.1 Reading from a binary Excel file ('97-2003 format; *.xls)
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else if (Path.GetExtension(filePath).ToUpper() == ".CSV")
                {
                    var conf = new ExcelReaderConfiguration() {
                        AutodetectSeparators = new char[] { ';', '\t', '|', '#'},
                    };
                    excelReader = ExcelReaderFactory.CreateCsvReader(stream, conf);
                }
                else
                {
                    //1.2 Reading from a OpenXml Excel file (2007 format; *.xlsx)
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }

                //2. DataSet - The result of each spreadsheet will be created in the result.Tables
                DataSet ds = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                dataTable = ds.Tables[0];

                //5. Free resources (IExcelDataReader is IDisposable)
                excelReader.Close();

                // Source: https://stackoverflow.com/questions/27634477/using-exceldatareader-to-read-excel-data-starting-from-a-particular-cell 
                // Lösung angepasst...
            }
            return dataTable;


        }


    }
}
