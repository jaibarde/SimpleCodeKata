﻿using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    /// <summary>
    /// A _leastRecentlyUsedOrderedObjects that is sorted so that the recentlyUsedItem added least recently is at the beginning of the _leastRecentlyUsedOrderedObjects and recentlyUsedItem added last is at the bottom. 
    /// If an recentlyUsedItem is added more than once, it appears in the _leastRecentlyUsedOrderedObjects only once, in the position determined by the time it was added last.
    /// </summary>

    public class LeastRecentlyUsedList
    {
        private readonly List<string> _leastRecentlyUsedOrderedObjects;

        public LeastRecentlyUsedList()
        {
            _leastRecentlyUsedOrderedObjects = new List<string>();
        }

        /// <summary>
        /// Adds an recentlyUsedItem to the end of the _leastRecentlyUsedOrderedObjects, or, if the recentlyUsedItem has already been added, moves it to the end.
        /// </summary>
        /// <param name="recentlyUsedItem">The recentlyUsedItem to add.</param>
        public void Add(string recentlyUsedItem)
        {
            if (_leastRecentlyUsedOrderedObjects.Contains(recentlyUsedItem))
            {
                var index = _leastRecentlyUsedOrderedObjects.IndexOf(recentlyUsedItem);
                var existingItem = _leastRecentlyUsedOrderedObjects[index];
                _leastRecentlyUsedOrderedObjects.RemoveAt(index);
                _leastRecentlyUsedOrderedObjects.Insert(0, existingItem);
            }
            else
            {
                _leastRecentlyUsedOrderedObjects.Insert(0, recentlyUsedItem);
            }
        }

        /// <summary>
        /// Returns the number of items in the _leastRecentlyUsedOrderedObjects.
        /// </summary>
        public int Count
        {
            get
            {
                var size = _leastRecentlyUsedOrderedObjects.Count;
                return size;
            }
        }

        /// <summary>
        /// Returns the recentlyUsedItem in the _leastRecentlyUsedOrderedObjects at the specified position. LeastRecentlyUsedList[Count - 1] returns the recentlyUsedItem that was added most recently.
        /// </summary>
        /// <param name="index">The position of the recentlyUsedItem to be retrieved from the _leastRecentlyUsedOrderedObjects.</param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                var position = 0;
                foreach (var item in _leastRecentlyUsedOrderedObjects)
                {
                    if (position == index)
                        return item;
                    ++position;
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public string Output()
        {
            return _leastRecentlyUsedOrderedObjects.ToCommaSeparatedList();
        }
    }
}
