using System;
using System.Linq;
using System.Linq.Expressions;
using HAL.Exceptions;

namespace HAL.Collections
{
    public class HalCustomValidateList<T> : HalList<T>
    {
        private Func<T, bool> _expression;

        //TODO arrumar esse objeto precisa o cara colocar assim (x=> x.nome) que ai ele não permite que add itens com o nome igual.
        /// <summary>
        /// This is a list that can have a custom validation for every item added
        /// </summary>
        /// <param name="expression">Condition to Validate Every Item Added in the list</param>
        public HalCustomValidateList(Func<T, bool> expression)
        {
            _expression = expression;
            this.BeforeAddItem += new AddItemDelegate(HalExclusiveList_BeforeAddItem);
            this.BeforeInsertItem += new InsertItemDelegate(HalExclusiveList_BeforeInsertItem);
        }

        void HalExclusiveList_BeforeInsertItem(int index, T item)
        {
            bool val = _expression.Invoke(item);
            if (!val)
            {
                throw new HalInvalidValueException("Invalid Value");
            }
        }

        void HalExclusiveList_BeforeAddItem(T item)
        {
            bool val = _expression.Invoke(item);
            if (!val)
            {
                throw new HalInvalidValueException("Invalid Value");
            }

        }
    }
}