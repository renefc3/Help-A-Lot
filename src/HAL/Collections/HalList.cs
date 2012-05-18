using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HAL.Collections
{
    public class HalList<T> : IList<T>
    {
        public delegate void AddItemDelegate(T item);
        public delegate void RemoveItemDelegate(T item);

        public delegate void InsertItemDelegate(int index, T item);
        public delegate void RemoveAtItemDelegate(int index);

        public event InsertItemDelegate BeforeInsertItem;
        public event InsertItemDelegate AfterInsertItem;

        public event RemoveAtItemDelegate BeforeRemoveAtItem;
        public event RemoveAtItemDelegate AfterRemoveAtItem;

        public event AddItemDelegate BeforeAddItem;
        public event AddItemDelegate AfterAddItem;

        public event RemoveItemDelegate BeforeRemoveItem;
        public event RemoveItemDelegate AfterRemoveItem;


        private IList<T> _list;

        public HalList()
        {
            _list = new List<T>();
        }



        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            BeforeAddItem(item);
            _list.Add(item);
            AfterAddItem(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            BeforeRemoveItem(item);
            bool ret = _list.Remove(item);
            AfterRemoveItem(item);
            return ret;
        }

        public int Count
        {
            get { return _list.Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            BeforeInsertItem(index, item);
            _list.Insert(index, item);
            AfterInsertItem(index, item);
        }

        public void RemoveAt(int index)
        {
            BeforeRemoveAtItem(index);
            _list.RemoveAt(index);
            AfterRemoveAtItem(index);
        }

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

























    }
}