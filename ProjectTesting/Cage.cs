using System.Data;

namespace ProjectTesting
{
    /// <summary>
    /// This class represents a bird in our program, it has all the necessary parameters and methods 
    /// </summary>
    public class Cage
    {
        // Fields
        public string Id { get; set; }
        public string Material { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public List<Bird> BirdList { get; set; } // a list of birds that are in the cage

        // Constructor
        public Cage(string[] cageInfo) // cageInfo is a string array that holds all of the important info about the cage
        {
            Id = cageInfo[0];
            Length = cageInfo[1];
            Width = cageInfo[2];
            Height = cageInfo[3];
            Material = cageInfo[4];

            BirdList = new List<Bird>(); // when creating a new cage it doesnt have birds
        }

        public Cage(Cage otherCage)
        {
            Id = otherCage.Id;
            Material = otherCage.Material;
            Length = otherCage.Length;
            Width = otherCage.Width;
            Height = otherCage.Height;

            BirdList = otherCage.BirdList.Select(b => new Bird(b)).ToList(); //copys the list to current object
        }

        public void AddBird(Bird bird) // adding an bird into the list of birds of the cage
        {
            BirdList.Add(bird);
        }

        public void SetBirdList(List<Bird> list)
        {
            BirdList = list;
        }

        public string[] ToStringArray() //turns the cage into a string array representation
        {
            string[] cageInfo = new string[5] { this.Id, this.Length, this.Width, this.Height, this.Material };
            return cageInfo;
        }

        public void EditFields(string[] cageInfo) // allows us to edit the cage info
        {
            this.Id = cageInfo[0];
            this.Length = cageInfo[1];
            this.Width = cageInfo[2];
            this.Height = cageInfo[3];
            this.Material = cageInfo[4];
        }
    }
}
