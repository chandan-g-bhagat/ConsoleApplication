using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Computer
{
    public class CustomStack
    {
        private int[] _item { get; set; }
        public int Count = 0;

        public CustomStack(int i)
        {
            _item = new int[i];
        }

        public CustomStack()
        {
            _item = new int[10];
        }

        public void Push(int i)
        {
            if (Count<10)
            {
                _item[Count] = i;
                Count++;
            }
        }

        public void Pop()
        {
            if (Count>0)
            {
                _item[Count - 1] = 0;
                Count--;
            }
        }

        public int[] GetItem()
        {
            int[] tmp = new int[Count];
            Array.Copy(_item, tmp, Count);
            return tmp;

        }
    }
}
