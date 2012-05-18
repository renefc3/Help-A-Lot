using System;
using System.Linq;
namespace HAL.Collections
{
    public class HalExclusiveList<T> : HalList<T>
    {
        public HalExclusiveList()
        {
            this.BeforeAddItem += new AddItemDelegate(HalExclusiveList_BeforeAddItem);
            this.BeforeInsertItem += new InsertItemDelegate(HalExclusiveList_BeforeInsertItem);
        }

        void HalExclusiveList_BeforeInsertItem(int index, T item)
        {     
            if (this.Contains(item))
            {
                throw new HalDuplicityException("List already have the item in the list");
            }
        }

        void HalExclusiveList_BeforeAddItem(T item)
        {

            if (this.Contains(item))
            {
                throw new HalDuplicityException("List already have the item in the list");
            }
        }
    }

}