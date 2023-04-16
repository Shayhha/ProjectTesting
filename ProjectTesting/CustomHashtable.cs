using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting
{
    public class CustomHashtable
    {
        private Dictionary<string, List<string[]>> birdHashtable = new Dictionary<string, List<string[]>>();
        private Dictionary<string, List<string[]>> cageHashtable = new Dictionary<string, List<string[]>>();

        public void AddBiirdToHashtable(string[] bird)
        {
            string[] birdKeyOptions = { bird[0], bird[1], bird[2] };

            foreach (string birdKey in birdKeyOptions)
            {
                if (!birdHashtable.ContainsKey(birdKey))
                {
                    birdHashtable[birdKey] = new List<string[]>();
                }
                birdHashtable[birdKey].Add(bird);
            }
        }

        public void AddCageToHashtable(string[] cage)
        {
            string[] cageKeyOptions = { cage[0], cage[3] };

            foreach (string cageKey in cageKeyOptions)
            {
                if (!cageHashtable.ContainsKey(cageKey))
                {
                    cageHashtable[cageKey] = new List<string[]>();
                }
                cageHashtable[cageKey].Add(cage);
            }
        }

        public List<string[]> SearchBirdHashtable(string searchType)
        {
            if (birdHashtable.ContainsKey(searchType))
            {
                return birdHashtable[searchType];
            }
            else
            {
                return new List<string[]>();
            }
        }

        public List<string[]> SearchCageHashtable(string searchType)
        {
            if (cageHashtable.ContainsKey(searchType))
            {
                return cageHashtable[searchType];
            }
            else
            {
                return new List<string[]>();
            }
        }
    }

}
