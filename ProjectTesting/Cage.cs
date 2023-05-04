using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting
{
    public class Cage
    {
        // Fields
        private string Id { get; set; }
        private string Material { get; set; }
        private string Length { get; set; }
        private string Width { get; set; }
        private string Height { get; set; }
        private List<Bird> BirdList { get; set; }

        // Constructor
        public Cage(string[] cageInfo)
        {
            Id = cageInfo[0];
            Material = cageInfo[4];
            Length = cageInfo[1];
            Width = cageInfo[2];
            Height = cageInfo[3];

            BirdList = new List<Bird>();
        }

        private void AddBird(Bird bird)
        {
            BirdList.Add(bird);
        }
    }
}
