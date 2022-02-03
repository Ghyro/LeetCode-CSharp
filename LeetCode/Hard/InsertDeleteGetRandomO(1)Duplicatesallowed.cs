using System;
using System.Collections.Generic;
using System.Linq;

namespace Hard
{
    // Issue: 381

    //RandomizedCollection is a data structure that contains a collection of numbers, possibly duplicates(i.e., a multiset).
    //It should support inserting and removing specific elements and also removing a random element.
    //Implement the RandomizedCollection class:
    //RandomizedCollection() Initializes the empty RandomizedCollection object.
    //bool insert(int val) Inserts an item val into the multiset, even if the item is already present.Returns true if the item is not present, false otherwise.
    //bool remove(int val) Removes an item val from the multiset if present.Returns true if the item is present, false otherwise.Note that if val has multiple occurrences in the multiset, we only remove one of them.
    //int getRandom() Returns a random element from the current multiset of elements.The probability of each element being returned is linearly related to the number of same values the multiset contains.
    //You must implement the functions of the class such that each function works on average O(1) time complexity.

    //Note: The test cases are generated such that getRandom will only be called if there is at least one item in the RandomizedCollection.

    public class RandomizedCollection
    {
        List<int> list;
        Dictionary<int, HashSet<int>> dict;
        Random rd;
        public RandomizedCollection()
        {
            list = new List<int>();
            dict = new Dictionary<int, HashSet<int>>();
            rd = new Random();
        }

        public bool Insert(int val)
        {
            bool doesExist = false;
            list.Add(val);
            if (!dict.ContainsKey(val))
            {
                dict.Add(val, new HashSet<int>());
                doesExist = true;
            }
            dict[val].Add(list.Count - 1);
            return doesExist;
        }

        public bool Remove(int val)
        {
            if (!dict.ContainsKey(val))
            {
                return false;
            }

            var indexToRemove = dict[val].First();
            dict[val].Remove(indexToRemove);
            var lastItemIndex = list.Count - 1;

            if (indexToRemove != lastItemIndex)
            {
                var swappedItem = list[lastItemIndex];
                list[indexToRemove] = swappedItem;
                dict[swappedItem].Add(indexToRemove);
                dict[swappedItem].Remove(lastItemIndex);
            }

            list.RemoveAt(lastItemIndex);

            if (dict[val].Count == 0)
            {
                dict.Remove(val);
            }

            return true;
        }

        public int GetRandom() => list[rd.Next(list.Count)];
    }
}
