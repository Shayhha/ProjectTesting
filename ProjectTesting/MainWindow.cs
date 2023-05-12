
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ProjectTesting

{
    public partial class MainWindow : Form
    {
        public static string UserSheet = ""; //this represents the logged in user sheet name
        public static CustomHashtable HashTable = null;
        private Excel UserExcel = new Excel("users", "default");

        public MainWindow()
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\parrot.ico");
            this.StartPosition = FormStartPosition.CenterScreen;
            Back_Button.Hide();
            hideTopBar();
            hideTopPanel();
        }

        public static void InitHashtable()
        {
            //sort the database first
            SortExcel("bird");
            SortExcel("cage");
            int BirdSize = LogIn.DataBaseExcel.GetLastRow(7);
            int CageSize = LogIn.DataBaseExcel.GetLastRow(1);

            for (int i = 1; i < BirdSize; i++) //add birds to bird hashtable
            {
                string[] temp = LogIn.DataBaseExcel.ReadRange(i, 7, 15);
                Bird bird = new Bird(temp);
                HashTable.AddBirdToHashtable(bird);
            }
            for (int i = 1; i < BirdSize; i++) //add offsprings to each bird in bird hashtable from database
            {
                string[] temp = LogIn.DataBaseExcel.ReadRange(i, 7, 16);
                List<Bird> bird = HashTable.SearchBirdHashtable(temp[0]); //searches the bird id in hashtable
                if (!(bird[0].isOffspring) && temp[9] != "none") //if the bird is adult we check if it has offsprings
                {
                    string[] offspringList = temp[9].Split("|"); //splits the string of offsprings to string[] array
                    foreach (string offspringId in offspringList)
                    {
                        List<Bird> offspring = HashTable.SearchBirdHashtable(offspringId);
                        bird[0].AddOffspring(offspring[0]);
                    }
                }
                //if((bird[0].OffspringList.Count != 0))
                //    MessageBox.Show(bird[0].OffspringList[0].Id);
            }

            for (int i = 1; i < CageSize; i++) //add cages to cage hashtable
            {
                string[] temp = LogIn.DataBaseExcel.ReadRange(i, 1, 5);
                Cage cage = new Cage(temp);
                HashTable.AddCageToHashtable(cage);
            }
            for (int i = 1; i < CageSize; i++) //add birds to each cage in cage hashtable from database
            {
                string[] temp = LogIn.DataBaseExcel.ReadRange(i, 1, 5);
                List<Cage> cage = HashTable.SearchCageHashtable(temp[0]); //searches the cage id in hashtable
                cage[0].SetBirdList(HashTable.SearchBirdHashtable(temp[0])); //adds the birds to matching cage
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Here we initialize the user hashtable for use later in program
            HashTable = new CustomHashtable(); //first initializing of hashtable!!
            int size = UserExcel.GetLastRow();
            string[] temp = null;

            for (int i = 1; i < size; i++)
            {
                temp = UserExcel.ReadRange(i, 1, 3);
                HashTable.AddUserToHashtable(temp);
            }
            UserExcel.Quit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When we close the program, we need to free up the memeory initialized in Load method
            try
            {
                // Dispose of Excel instance
                Marshal.ReleaseComObject(UserExcel.getWs());
                Marshal.ReleaseComObject(UserExcel.getWb());
                Marshal.ReleaseComObject(UserExcel.getExcel());
                UserExcel = null;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during dispose
                MessageBox.Show("Error disposing of Excel instance: " + ex.Message);
            }
        }

        public void loginToSignUp()
        {
            logIn1.Hide();
            signUp1.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logIn1.Show();
            homePage1.Hide();
            searchBird1.Hide();
            addBird1.Hide();
            addCage1.Hide();
            moreDetails1.Hide();
            hideTopBar();
            hideBackBtn();
            hideTopPanel();
            HashTable.ClearBirdCageHashtable(); //clear bird and cage hashtables
        }

        public void showTopBar()
        {
            logOutButton.Show();
            Bird_label.Show();
            Cage_label.Show();
            dashboardButton.Show();
        }

        public void hideTopBar()
        {
            logOutButton.Hide();
            Bird_label.Hide();
            Cage_label.Hide();
            dashboardButton.Hide();
        }

        public void showTopPanel() { headlinePanel.Show(); }
        public void hideTopPanel() { headlinePanel.Hide(); }

        public void showBackBtn() { Back_Button.Show(); }
        public void hideBackBtn() { Back_Button.Hide(); }

        public void setBirdsLabel(string number)
        {
            Bird_label.Text = "Birds: " + number;
        }
        public void setCagesLabel(string number)
        {
            Cage_label.Text = "Cages: " + number;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            if (searchBird1.Visible == true)
            {
                if (searchBird1.Search_textbox.Text != "") { searchBird1.Search_textbox.Text = ""; }
                searchBird1.Hide();
                hideBackBtn();
                homePage1.Show();
            }
            else if (moreDetails1.Visible == true)
            {
                if (homePage1.OneOption == true)
                {
                    searchBird1.Search_textbox.Text = "";
                    moreDetails1.Hide();
                    hideBackBtn();
                    homePage1.Show();
                    homePage1.OneOption = false;
                }
                else
                {
                    searchBird1.Search_textbox.Text = "";
                    moreDetails1.Hide();
                    searchBird1.Show();
                }
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            UserDash dash = new UserDash();
            dash.initDash();
            dash.Show();
        }


        //helper function for program, QuickSort and SortExcel function
        public static void SortExcel(string name) //name can be "bird" or "cage"
        {
            int size = 1; //default value
            int colStart = 7;  //default value
            int colEnd = 16; //default vaule
            int flag = 0;
            
            if (name == "bird")
            {
                size = LogIn.DataBaseExcel.GetLastRow(7) - 1;
                colStart = 7;
                colEnd = 16;
            }
            else if (name == "cage")
            {
                size = LogIn.DataBaseExcel.GetLastRow(1) - 1;
                colStart = 1;
                colEnd = 5;
            }
            else //means we got invalid string for operation, we do nothing
            {
                flag = 1;
            }

            if (flag == 0)
            {
                string[][] arr = new string[size][]; //initalize the double array //size is -1 because of our default line in Shay!
                int index = 0; //index for array

                for (int i = 1; i < size + 1; i++)
                {
                    string[] temp = LogIn.DataBaseExcel.ReadRange(i, colStart, colEnd);
                    arr[index] = temp;
                    index++;//increment index 
                }
                //now we have an arr with all birds\cages inside, not sorted
                if (name == "cage")
                    Array.Sort(arr, (x, y) => x[0].CompareTo(y[0]));// using lambda to sort cages
                else
                    Sort(arr, 0, arr.Length - 1);//here we call Sort method 

                index = 0;
                for (int j = 1; j < size + 1; j++) //now we going through the database and update the birds list 
                {
                    LogIn.DataBaseExcel.WriteRange(j, colStart, colEnd, arr[index]);
                    index++;
                }
            }
        }

        public static int Partition(string[][] arr, int Start, int End)
        {
            int i = Start - 1;//represents the small elements
            int pivot = int.Parse(arr[End][0]);

            for (int j = Start; j < End; j++)
            {
                if (int.Parse(arr[j][0]) <= pivot) //if found a smaller num we switch numbers
                {
                    i++;// increase index

                    string[] temp1 = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp1;
                }
            }
            //now we need to do last switch with last index and last small element
            string[] temp = arr[i + 1];
            arr[i + 1] = arr[End];
            arr[End] = temp;

            return i + 1;
        }

        public static void Sort(string[][] arr, int Start, int End)
        {
            if (Start < End)
            {
                int pr = Partition(arr, Start, End); //represends the pivot in sorting
                                                     //calls recursivly for first part until pr and from pr+1 to end
                Sort(arr, Start, pr - 1);
                Sort(arr, pr + 1, End);
            }
        }
    }
}