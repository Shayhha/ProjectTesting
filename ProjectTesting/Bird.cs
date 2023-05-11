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

        // Constructors
        public Bird(string[] birdInfo) //ctor
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

        public Bird(Bird bird) //copy ctor
        {
            Id = bird.Id;
            Type = bird.Type;
            SubType = bird.SubType;
            DateOfBirth = bird.DateOfBirth;
            Gender = bird.Gender;
            CageId = bird.CageId;
            DadId = bird.DadId;
            MomId = bird.MomId;
            isOffspring = bird.isOffspring;
            OffspringList = bird.OffspringList.Select(b => new Bird(b)).ToList(); //copys the list to current object
        }

        public void AddOffspring(Bird offspring)
        {
            OffspringList.Add(offspring);
        }

        public string[] ToStringArray() //string array representation of class
        {
            string[] birdInfo;
            if (OffspringList.Count == 0) {
                birdInfo = new string[10] { this.Id, this.Type, this.SubType, this.DateOfBirth, this.Gender, this.CageId, this.DadId, this.MomId, "", "none" };
            }
            else
            {
                string offsprings = "";
                foreach (Bird offspring in OffspringList)
                {
                    offsprings += offspring.Id;
                }
                birdInfo = new string[10] { this.Id, this.Type, this.SubType, this.DateOfBirth, this.Gender, this.CageId, this.DadId, this.MomId, "", offsprings };
            }

            if (isOffspring) // can be "true" or "false"
                birdInfo[8] = "yes";
            else
                birdInfo[8] = "no";

            return birdInfo;
        }

        public void EditFields(string[] bird)
        {
            Id = bird[0];
            Type = bird[1];
            SubType = bird[2];
            DateOfBirth = bird[3];
            Gender = bird[4];
            CageId = bird[5];
            DadId = bird[6];
            MomId = bird[7];
        }
    }

}
