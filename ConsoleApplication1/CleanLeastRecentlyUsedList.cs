using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// A leastRecentlyUsedOrderedObjects that is sorted so that the recentlyUsedItem added least recently is at the beginning of the leastRecentlyUsedOrderedObjects and recentlyUsedItem added last is at the bottom. 
    /// If an recentlyUsedItem is added more than once, it appears in the leastRecentlyUsedOrderedObjects only once, in the position determined by the time it was added last.
    /// </summary>

    public class LeastRecentlyUsedString
    {
        private readonly List<string> _leastRecentlyUsedOrderedObjects;

        public LeastRecentlyUsedString()
        {
            _leastRecentlyUsedOrderedObjects = new List<string>();
        }

        /// <summary>
        /// Adds an recentlyUsedItem to the end of the leastRecentlyUsedOrderedObjects, or, if the recentlyUsedItem has already been added, moves it to the end.
        /// </summary>
        /// <param name="recentlyUsedItem">The recentlyUsedItem to add.</param>
        public void Add(string recentlyUsedItem)
        {
            _leastRecentlyUsedOrderedObjects.Remove(recentlyUsedItem);
            _leastRecentlyUsedOrderedObjects.Insert(0, recentlyUsedItem);
        }

        /// <summary>
        /// Returns the number of items in the leastRecentlyUsedOrderedObjects.
        /// </summary>
        public int Count => _leastRecentlyUsedOrderedObjects.Count;

        /// <summary>
        /// Returns the recentlyUsedItem in the leastRecentlyUsedOrderedObjects at the specified position. LeastRecentlyUsedString[Count - 1] returns the recentlyUsedItem that was added most recently.
        /// </summary>
        /// <param name="index">The position of the recentlyUsedItem to be retrieved from the leastRecentlyUsedOrderedObjects.</param>
        /// <returns></returns>
        public string this[int index] => _leastRecentlyUsedOrderedObjects.ElementAt(index-1);
        public string Output()
        {
            return _leastRecentlyUsedOrderedObjects.ToCommaSeparatedList();
        }
    }
}
