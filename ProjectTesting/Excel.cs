﻿using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ProjectTesting
{
    class Excel
    {
        private string path = "";
        private _Application excel = new _Excel.Application();
        private Workbook wb;
        private Worksheet ws;
        


        private static string USERS_PATH = Directory.GetCurrentDirectory().Split("bin")[0] + "Excel\\Users.xlsx";
        private static string DATABASE_PATH = Directory.GetCurrentDirectory().Split("bin")[0] + "Excel\\Database.xlsx";

        /// <summary>
        /// A constructor for class Excel, it anables us to open a file and do stuff with it like read and write
        /// </summary>
        /// <param name="fileName">Enter "users" for the users file and "database" for the database file, any other strings will not work</param>
        /// <param name="sheetName">Enter the name of the sheet you want to access</param>
        public Excel(string fileName, string sheetName) //ctor for Excel 
        {
            try{
                if (fileName == "users"){
                    this.path = USERS_PATH;
                }
                else if (fileName == "database"){
                    this.path = DATABASE_PATH;
                }
                else{
                    throw new Exception("Failed to open file..");
                }
                wb = excel.Workbooks.Open(path);
                ws = wb.Sheets[sheetName];
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                
            }
            
        }

        public string ReadCell(string cell) // reads single cell in file
        {
            string content = "";
            if (ws.Range[cell].Value != null)
            {
                content = ws.Range[cell].Value.ToString();
            }
            return content;
        }


        public string[] ReadRange(int row, int colStart, int colEnd)//reads multiple lines in excel file and returns array
        {
            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[row, colStart], ws.Cells[row, colEnd + 1]];
            object[,] holder = range.Value2;
            string[] returnstring = new string[colEnd + 1  - colStart];

            for (int q = 1; q <= colEnd + 1 - colStart; q++)
            {
                returnstring[q - 1] = holder[1,q].ToString();
            }
            
            return returnstring;
        }

        public void WriteCell(string cell, string value) //write to specific cell
        {
            ws.Range[cell].Value2 = value;
            Save();
        }

        public void WriteRange(int row, int colStart, int colEnd, string[] writeString) //write to multiple cells
        {
            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[row, colStart], ws.Cells[row, colEnd]];
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

        public int GetLastRow(int num = 1)
        {
            if(num > 15 || num < 7) //if we recevie a wrong number we give it default value and coninue
            {
                num = 1;
            }

            int i = 1;
            while (ws.Cells[i, num].Value != null)
            {
                i++;
            }

            return i;
        }

    }
}
