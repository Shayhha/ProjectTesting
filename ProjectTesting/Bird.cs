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
        private string Id { get; set; }
        private string Type { get; set; }
        private string SubType { get; set; }
        private string DateOfBirth { get; set; }
        private string Gender { get; set; }
        private string CageId { get; set; }
        private string DadId { get; set; }
        private string MomId { get; set; }
        private bool isOffspring { get; set; }
        private List<Bird> OffspringList { get; set; }

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

        private void AddOffspring(Bird offspring)
        {
            OffspringList.Add(offspring);
        }

        private void SetBirdList(List<Bird> list)
        {
            OffspringList = list;
        }
    }

}
