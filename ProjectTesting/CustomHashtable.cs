using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting
{
    public class CustomHashtable
    {
        private Dictionary<string, List<Bird>> birdHashtable = new Dictionary<string, List<Bird>>();
        private Dictionary<string, List<Cage>> cageHashtable = new Dictionary<string, List<Cage>>();
        private Dictionary<string, List<string[]>> userHashtable = new Dictionary<string, List<string[]>>();

        public void AddBirdToHashtable(Bird bird) //method to add bird to hashtable
        {
            //string to hold search result we want to add to hashtable
            string[] birdKeyOptions = { bird.Id, bird.Type, bird.SubType, bird.DateOfBirth, bird.Gender, bird.CageId };

            foreach (string birdKey in birdKeyOptions) //goes through each search type and adds it to hashtable in chaining method
            {
                if (!birdHashtable.ContainsKey(birdKey)) //checks if bird is present in hashtable
                {
                    birdHashtable[birdKey] = new List<Bird>(); //creates an empty list
                }
                birdHashtable[birdKey].Add(bird); //adds bird to list 
            }
            List<Cage> cage = SearchCageHashtable(bird.CageId); //search cage 
            cage[0].BirdList = birdHashtable[bird.CageId]; //update cage bird list
        }

        public void AddCageToHashtable(Cage cage) //method to add cage to hashtable
        {
            string[] cageKeyOptions = { cage.Id, cage.Material }; //string to hold search result we want to add to hashtable

            foreach (string cageKey in cageKeyOptions) //goes through each search type and adds it to hashtable in chaining method
            {
                if (!cageHashtable.ContainsKey(cageKey)) //checks if cage is present in hashtable
                {
                    cageHashtable[cageKey] = new List<Cage>(); //creates an empty list
                }
                cageHashtable[cageKey].Add(cage); //adds cage to list 
            }
        }

        public void AddUserToHashtable(string[] user) //method to add user to hashtable
        {
            string[] userKeyOptions = { user[0], user[2] }; //string to hold search result we want to add to hashtable

            foreach (string userKey in userKeyOptions) //goes through each search type and adds it to hashtable in chaining method
            {
                if (!userHashtable.ContainsKey(userKey)) //checks if user is present in hashtable
                {
                    userHashtable[userKey] = new List<string[]>(); //creates an empty list
                }
                userHashtable[userKey].Add(user); //adds user to list 
            }
        }

        public List<Bird> SearchBirdHashtable(string searchType) //search bird in hashtable
        {
            if (birdHashtable.ContainsKey(searchType)) //checks if search type is present in hashtable
            {
                return birdHashtable[searchType]; //returns the list of search type
            }
            else //else we didn't find anything so we return an empty list
            {
                return new List<Bird>();
            }
        }

        public List<Cage> SearchCageHashtable(string searchType) //search cage in hashtable
        {
            if (cageHashtable.ContainsKey(searchType)) //checks if search type is present in hashtable
            {
                return cageHashtable[searchType]; //returns the list of search type
            }
            else //else we didn't find anything so we return an empty list
            {
                return new List<Cage>();
            }
        }

        public List<string[]> SearchUserHashtable(string searchType) //method for searching user
        {
            if (userHashtable.ContainsKey(searchType)) //checks if user is present in hashtable
            {
                return userHashtable[searchType]; //returns the user
            } 
            else //else we didn't find a user so we return an empty string array (to check if we found a user or not)
            {
                List<string[]> list = new List<string[]>();
                string[] default1 = { "" };
                list.Add(default1);
                return list; //returns an empty string array with first string has ""
            }
        }

        public void ClearBirdCageHashtable() //clears bird & cage hashtables
        { 
            birdHashtable.Clear();
            cageHashtable.Clear();
        }

        public void AddBirdIdToHashtable(Bird bird) //adds bird to hashtable only by id
        {
            if (!birdHashtable.ContainsKey(bird.Id)) //checks if id is in bird hashtable
            {
                birdHashtable[bird.Id] = new List<Bird>(); //creates new list in index
            }
            birdHashtable[bird.Id].Add(bird); //add bird object to list
        }

        public void AddBirdParameterToHashtable(Bird bird, string parameter) //adds specific parameter to bird hashtable
        {
            if (!birdHashtable.ContainsKey(parameter)) //checks if parameter is in bird hashtable
            {
                birdHashtable[parameter] = new List<Bird>(); //creates new list in index
            }
            birdHashtable[parameter].Add(bird); //add bird object to list
        }

        public void AddCageIdToBirdHashtable(Bird bird) //adds cage id to bird hashtable
        {
            if (!birdHashtable.ContainsKey(bird.CageId)) //checks if id is in bird hashtable
            {
                birdHashtable[bird.CageId] = new List<Bird>(); //creates new list in index
            }
            birdHashtable[bird.CageId].Add(bird); //add bird object to list
            List<Cage> cage = SearchCageHashtable(bird.CageId); //search cage 
            cage[0].BirdList = birdHashtable[bird.CageId]; //update cage bird list
        }

        public void AddCageIdToHashtable(Cage cage, string oldCageId) //adds cage to hashtable only by id
        {
            if (!cageHashtable.ContainsKey(cage.Id)) //checks if id is in cage hashtable
            {
                cageHashtable[cage.Id] = new List<Cage>(); //creates new list in that new index
            }
            cageHashtable[cage.Id].Add(cage); //adds cage object to list 

            //update bird hashtable with new cage id hash code
            RemoveBirdFromHashtable(oldCageId); //remove old cage id from bird hashtable
            if (!birdHashtable.ContainsKey(cage.Id)) //checks id is inside bird hashtable
            {
                birdHashtable[cage.Id] = new List<Bird>(); //create new list in index
            }
            birdHashtable[cage.Id] = cage.BirdList; //give the index the bird list
        }

        public void AddCageMaterialToHashtable(Cage cage) //adds new cage by material 
        {
            if (!cageHashtable.ContainsKey(cage.Material)) //checks if Material is in cage hashtable
            {
                cageHashtable[cage.Material] = new List<Cage>(); //creates new list in that new index
            }
            cageHashtable[cage.Material].Add(cage); //adds cage object to list 
        }

        public void RemoveBirdFromHashtable(string birdId) //remove the old bird id hashcode from hashtable
        {
            if (birdHashtable.ContainsKey(birdId)) //checks if id is present
            {
                birdHashtable.Remove(birdId); //deletes the id
            }
        }

        public void RemoveCageFromHashtable(string cageId) //remove the old cage id hashcode from hashtable
        {
            if (cageHashtable.ContainsKey(cageId)) //checks if id is present
            {
                cageHashtable.Remove(cageId); //deletes id
            }
        }
    }

}
