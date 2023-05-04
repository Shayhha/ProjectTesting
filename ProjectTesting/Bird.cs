using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting
{
    public class Bird
    {
        // Fields
        public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string CageId { get; set; }
        public string DadId { get; set; }
        public string MomId { get; set; }
        public bool isOffspring { get; set; }
        public List<Bird> OffspringList { get; set; }

        // Constructor
        public Bird(string[] birdInfo) 
        {
            Id = birdInfo[0];
            Type = birdInfo[1];
            SubType = birdInfo[2];
            DateOfBirth = birdInfo[3];
            Gender = birdInfo[4];
            CageId = birdInfo[5];
            DadId = birdInfo[6];
            MomId = birdInfo[7];

            if (birdInfo[8] == "yes")
                isOffspring = true;
            else
                isOffspring = false;

            OffspringList = new List<Bird>();
        }

        public void AddOffspring(Bird offspring)
        {
            OffspringList.Add(offspring);
        }

        public string[] ToStringArray() //string array representation of class
        {
            string[] birdInfo = new string[9] { this.Id,this.Type, this.SubType, this.DateOfBirth, this.Gender, this.CageId, this.DadId, this.MomId, "" };
            if (isOffspring) // can be "true" or "false"
                birdInfo[8] = "yes";
            else
                birdInfo[8] = "no";
            return birdInfo;
        }
    }

}
