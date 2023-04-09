using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class SearchBird : UserControl
    {
        public SearchBird()
        {
            InitializeComponent();
        }

        public void Search(string name)
        {
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int size = ex.GetLastRow();
            string[] temp = null;

            for (int i = 1; i < size; i++)
            {
                temp = ex.ReadRange(i, 7, 14);
                if (temp.Contains(name))
                {
                    string[] newStr = { "Bird ID: " + temp[0], "Type: " + temp[1], "gender: " + temp[4], "Cage ID: " + temp[5] + " | click for more details" };
                };

                    birdList.Items.AddRange(temp[i]);
                
            }
        }
    }
}
