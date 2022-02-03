using System;
using System.Collections.Generic;
using System.Text;

namespace Medium
{
    // Issue: 380

    //Implement the RandomizedSet class:

    //RandomizedSet() Initializes the RandomizedSet object.
    //bool insert(int val) Inserts an item val into the set if not present.Returns true if the item was not present, false otherwise.
    //bool remove(int val) Removes an item val from the set if present.Returns true if the item was present, false otherwise.
    //int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element exists when this method is called). Each element must have the same probability of being returned.
    //You must implement the functions of the class such that each function works in average O(1) time complexity.

    public class RandomizedSet
    {
        Dictionary<int, int> dct;
        List<int> list;
        Random rd;
        public RandomizedSet()
        {
            dct = new Dictionary<int, int>();
            list = new List<int>();
            rd = new Random();
        }

        public bool Insert(int val)
        {
            if (dct.ContainsKey(val)) 
                return false;

            list.Add(val);
            dct.Add(val, list.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (!dct.ContainsKey(val))
                return false;

            var indexToUpdate = dct[val];
            list[indexToUpdate] = list[list.Count - 1];
            dct[list[indexToUpdate]] = indexToUpdate;
            list.RemoveAt(list.Count - 1);
            dct.Remove(val);

            return true;
        }

        public int GetRandom() => list[rd.Next(0, list.Count)];
    }
}
