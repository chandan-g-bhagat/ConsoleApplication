using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Computer
{
    public class CustomQueue
    {
        private int[] _item = new int[10];
        public int Count = 0;

        public void Enqueue(int i)
        {
            _item[Count] = i;
            Count++;
        }

        public void Dequeue()
        {
            for (int i = 1; i < Count; i++)
            {
                _item[i - 1] = _item[i];
            }
            _item[Count - 1] = 0;
            Count--;
        }

        public int[] GetItem()
        {
            int[] tmp = new int[Count];
            Array.Copy(_item, tmp, Count);
            return tmp;

        }


    }
}











