using System;
using System.Collections.Generic;

namespace StackCOnsoleApp

{
    public class Stack
    {
        private readonly List<object> list;

        public Stack()
        {
            list = new List<object>();

        }
       public void Push(object item)
        {
            if(item == null)
            {
                throw new InvalidOperationException("Stack item cannot be null");
            }
            else
            {
                list.Add(item);
            }
        }

        public object Pop()
        {

            if (list.Count <= 0)
            {
                throw new InvalidOperationException("List cannot be empty");
            }
            else
            {
                var index = list.Count - 1;
                var lastElement = list[index];
                list.RemoveAt(index);
                return lastElement;
            }
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
