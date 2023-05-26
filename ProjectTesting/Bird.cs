
namespace ProjectTesting
{
    /// <summary>
    /// This class represents a bird in our program, it has all the necessary parameters and methods 
    /// </summary>
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
        public List<Bird> OffspringList { get; set; } // a list of Birds that are the offsprings of the current bird

        // Constructor
        public Bird(string[] birdInfo) // birdInfo is a string array that holds all of the important info about the bird
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

            OffspringList = new List<Bird>(); // when creating a new bird it doesnt have any offsprings
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

        public void AddOffspring(Bird offspring) // adding an offspring into the list of offsprings
        {
            OffspringList.Add(offspring);
        }

        public string[] ToStringArray() // turning the bird object into a string array representation
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
                    offsprings += offspring.Id + "|";
                }
                offsprings = offsprings.TrimEnd('|');
                birdInfo = new string[10] { this.Id, this.Type, this.SubType, this.DateOfBirth, this.Gender, this.CageId, this.DadId, this.MomId, "", offsprings };
            }

            if (isOffspring) // can be "true" or "false"
                birdInfo[8] = "yes";
            else
                birdInfo[8] = "no";

            return birdInfo;
        }

        public void EditFields(string[] bird) // allows us to edit the bird object
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
