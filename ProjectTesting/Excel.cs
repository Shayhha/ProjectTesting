using Microsoft.Office.Interop.Excel;
using System.IO;
using System;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ProjectTesting
{
    /// <summary>
    /// This class is our API with the excel files that act as our database. 
    /// The methods of this class alow us to open excel files, search for items in the database,
    /// write to the database, save the database and close it.
    /// We made it so that this class can only open two types of files, one for Users and the other for
    /// the birds and cages (we call it Database).
    /// </summary>
    public class Excel
    {
        // Every excel object will have these fields, an excel file based on a path, a workbook and a worksheet
        private string path = "";
        private _Application excel = new _Excel.Application();
        private Workbook wb;
        private Worksheet ws;
        
        // Here we get the path to the Users and the Database files from the programs directories regardless of the projects located on the users machine
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

        /// <summary>
        /// This method allows us to read a specific cell's information from the database.
        /// </summary>
        /// <param name="cell">is a string that looks like this: "B3" , it means that we go to column B,
        /// onto row 3 and return the information in that cell</param>
        /// <returns></returns>
        public string ReadCell(string cell) // reads single cell in file
        {
            string content = "";
            if (ws.Range[cell].Value != null) // if the value in the selected from is not null we save the value
            {
                content = ws.Range[cell].Value.ToString();
            }
            return content; // return the cell's value
        }

        /// <summary>
        /// This method allows us to search for an entier row on information in the database.
        /// For example we could search for row 5 in the database, from column 7 to column 16.
        /// The result will be the full information from the database about a bird (if the row is not empty)
        /// the first value will be the ID, the second is the type and so on.
        /// </summary>
        /// <param name="row">the row we want to search at</param>
        /// <param name="colStart">the starting column we want to get information from</param>
        /// <param name="colEnd">the last column we want to get information from</param>
        /// <returns>an array with strings that hold the values form the database</returns>
        public string[] ReadRange(int row, int colStart, int colEnd) //reads multiple lines in excel file and returns array
        {
            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[row, colStart], ws.Cells[row, colEnd + 1]];
            object[,] holder = range.Value2;
            string[] returnstring = new string[colEnd + 1  - colStart];

            for (int q = 1; q <= colEnd + 1 - colStart; q++) // goes over the columns and gets the information from the cells
            {
                returnstring[q - 1] = holder[1,q].ToString();
            }
            
            return returnstring;
        }

        /// <summary>
        /// This method writes information to the database into a specific cell.
        /// For example writeing "abcd" into a cell "G3"
        /// </summary>
        /// <param name="cell">a string that represents a cell, for example "G3"</param>
        /// <param name="value">a string that we want to input into the database</param>
        public void WriteCell(string cell, string value) //write to specific cell
        {
            ws.Range[cell].Value2 = value;
            Save(); // saving the database after inputting new data
        }

        /// <summary>
        /// This method writes an array of strings into the database in a specific row and columns.
        /// </summary>
        /// <param name="row">the row we want to write to</param>
        /// <param name="colStart">the column we want to start writing to</param>
        /// <param name="colEnd">the column we want to end our writing at</param>
        /// <param name="writeString">an array of string we want to write to the database</param>
        public void WriteRange(int row, int colStart, int colEnd, string[] writeString) 
        {
            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[row, colStart], ws.Cells[row, colEnd]];
            range.Value = writeString;
            Save(); // save the database
        }

        public void Save() // saving the current workbook
        {
            wb.Save();
        }

        public void Quit() // closing the excel file
        {
            excel.Quit();
        }

        /// <summary>
        /// This method allows us to create a new sheet in the excel file.
        /// We use it when creating a new user, after adding the new user to the users excel file
        /// we need to create a new sheet in the database excel file inorder to store the users information there.
        /// </summary>
        /// <param name="sheetName">this will be the username of the user</param>
        public void CreateNewSheet(string sheetName)
        {
            var lastSheet = wb.Sheets[wb.Sheets.Count];
            Worksheet tempSheet = wb.Worksheets.Add(After: lastSheet);
            tempSheet.Name = sheetName;
            Save(); // saving the excel file
        }

        public void SelectWorkSheet(string sheetName) // selecting a worksheet, sheetName will be the username of the user
        {
            this.ws = wb.Worksheets[sheetName];
        }

        /// <summary>
        /// This method tells us the number of the FIRST EMPTY ROW in the database in a given column.
        /// </summary>
        /// <param name="num">represents the column we want to search for the last row in
        /// num can be any value but is expected to be between 7 and 16 inorder to search for 
        /// the last row in the birds side of the database and 1 for the cage side of the database</param>
        /// <returns>the FIRST EMPTY ROW in a selected column</returns>
        public int GetLastRow(int num = 1)
        {
            if(num > 16 || num < 7) //if we recevie a wrong number we give it default value and coninue
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

        //get methods
        public _Application getExcel() { return this.excel; }
        public Workbook getWb() { return this.wb; }
        public Worksheet getWs() {return this.ws; }
    }
}
