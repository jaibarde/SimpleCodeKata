using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// A list that is sorted so that the item added least recently is at the beginning of the list and item added last is at the bottom. 
    /// If an item is added more than once, it appears in the list only once, in the position determined by the time it was added last.
    /// </summary>

    public class LeastRecentlyUsedList
    {
        private List<string> list;

        public LeastRecentlyUsedList()
        {
            list = new List<string>();
        }

        /// <summary>
        /// Adds an item to the end of the list, or, if the item has already been added, moves it to the end.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(string item)
        {
            if (list.Contains(item))
            {
                var index = list.IndexOf(item);
                var existingItem = list[index];
                list.RemoveAt(index);
                list.Insert(0, existingItem);
            }
            else
            {
                list.Insert(0, item);
            }
        }

        /// <summary>
        /// Returns the number of items in the list.
        /// </summary>
        public int Count
        {
            get
            {
                var size = list.Count;
                return size;
            }
        }

        /// <summary>
        /// Returns the item in the list at the specified position. LeastRecentlyUsedList[Count - 1] returns the item that was added most recently.
        /// </summary>
        /// <param name="index">The position of the item to be retrieved from the list.</param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                var position = 0;
                foreach (var item in list)
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
            return list.ToCommaSeparatedList();
        }
    }
}
