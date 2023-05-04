using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting
{
    public class CustomHashtable
    {
        private Dictionary<string, List<Bird>> birdHashtable = new Dictionary<string, List<Bird>>();
        private Dictionary<string, List<Cage>> cageHashtable = new Dictionary<string, List<Cage>>();
        private Dictionary<string, List<string[]>> userHashtable = new Dictionary<string, List<string[]>>();

        public void AddBirdToHashtable(Bird bird)
        {
            string[] birdKeyOptions = { bird.Id, bird.Type, bird.SubType, bird.DateOfBirth, bird.Gender, bird.CageId };

            foreach (string birdKey in birdKeyOptions)
            {
                if (!birdHashtable.ContainsKey(birdKey))
                {
                    birdHashtable[birdKey] = new List<Bird>();
                }
                birdHashtable[birdKey].Add(bird);
            }
        }

        public void AddCageToHashtable(Cage cage)
        {
            string[] cageKeyOptions = { cage.Id, cage.Material };

            foreach (string cageKey in cageKeyOptions)
            {
                if (!cageHashtable.ContainsKey(cageKey))
                {
                    cageHashtable[cageKey] = new List<Cage>();
                }
                cageHashtable[cageKey].Add(cage);
            }
        }

        public void AddUserToHashtable(string[] user)
        {
            string[] userKeyOptions = { user[0], user[2] };

            foreach (string userKey in userKeyOptions)
            {
                if (!userHashtable.ContainsKey(userKey))
                {
                    userHashtable[userKey] = new List<string[]>();
                }
                userHashtable[userKey].Add(user);
            }
        }

        public List<Bird> SearchBirdHashtable(string searchType)
        {
            if (birdHashtable.ContainsKey(searchType))
            {
                return birdHashtable[searchType];
            }
            else
            {
                return new List<Bird>();
            }
        }

        public List<Cage> SearchCageHashtable(string searchType)
        {
            if (cageHashtable.ContainsKey(searchType))
            {
                return cageHashtable[searchType];
            }
            else
            {
                return new List<Cage>();
            }
        }

        public List<string[]> SearchUserHashtable(string searchType)
        {
            if (userHashtable.ContainsKey(searchType))
            {
                return userHashtable[searchType];
            }
            else
            {
                List<string[]> list = new List<string[]>();
                string[] default1 = { "" };
                list.Add(default1);
                return list;
            }
        }
    }

}
