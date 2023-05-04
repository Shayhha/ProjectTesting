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
        public string Id { get; set; }
        public string Material { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public List<Bird> BirdList { get; set; }

        // Constructor
        public Cage(string[] cageInfo)
        {
            Id = cageInfo[0];
            Length = cageInfo[1];
            Width = cageInfo[2];
            Height = cageInfo[3];
            Material = cageInfo[4];

            BirdList = new List<Bird>();
        }

        public void AddBird(Bird bird)
        {
            BirdList.Add(bird);
        }

        public void SetBirdList(List<Bird> list)
        {
            BirdList = list;
        }

        public string[] ToStringArray() //string array representation of class
        {
            string[] cageInfo = new string[5] { this.Id, this.Length, this.Width, this.Height, this.Material };
            return cageInfo;
        }
    }
}
