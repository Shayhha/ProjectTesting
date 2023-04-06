﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.AxHost;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ProjectTesting
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        private static string USERS_PATH = "C:\\Users\\shayh\\Documents\\Visual Studio 2022\\Projects\\ProjectTesting\\ProjectTesting\\Excel\\Users.xlsx";
        private static string DATABASE_PATH = "C:\\Users\\shayh\\Documents\\Visual Studio 2022\\Projects\\ProjectTesting\\ProjectTesting\\Excel\\Database.xlsx";

        /// <summary>
        /// A constructor for class Excel, it anables us to open a file and do stuff with it like read and write
        /// </summary>
        /// <param name="fileName">Enter "users" for the users file and "database" for the database file, any other strings will not work</param>
        /// <param name="sheetName">Enter the name of the sheet you want to access</param>
        public Excel(string fileName, string sheetName)
        {
            if (fileName == "users")
            {
                path = USERS_PATH;
            }
            else if (fileName == "database")
            {
                path = DATABASE_PATH;
            }
            else
            {
                path = USERS_PATH; //this needs to be an error
            }
            wb = excel.Workbooks.Open(path);
            ws = wb.Sheets[sheetName];
        }

        public string ReadCell(string cell) // cell = "A2"
        {
            string content = "";
            if (ws.Range[cell].Value != null)
            {
                content = ws.Range[cell].Value;
            }
            return content;
        }


        public string[,] ReadRange(int starti, int starty, int endi, int endy)
        {
            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
            object[,] holder = range.Value2;
            string[,] returnstring = new string[endi - starti, endy - starty];
            for (int p = 1; p <= endi - starti; p++)
            {
                for (int q = 1; q <= endy - starty; q++)
                {
                    returnstring[p - 1, q - 1] = holder[p, q].ToString();
                }
            }
            return returnstring;
        }

        public void WriteCell(string cell, string value)
        {
            ws.Range[cell].Value2 = value;
            Save();
        }

        public void WriteRange(int starti, int starty, int endi, int endy, string[,] writeString)
        {
            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
            range.Value = writeString;
            Save();
        }

        public void Save()
        {
            wb.Save();
        }

        public void Quit()
        {
            excel.Quit();
        }

        public void CreateNewSheet(string sheetName)
        {
            var lastSheet = wb.Sheets[wb.Sheets.Count];
            Worksheet tempSheet = wb.Worksheets.Add(After: lastSheet);
            tempSheet.Name = sheetName;
            Save();
        }

        public void SelectWorkSheet(string sheetName)
        {
            this.ws = wb.Worksheets[sheetName];
        }
     
    }
}
