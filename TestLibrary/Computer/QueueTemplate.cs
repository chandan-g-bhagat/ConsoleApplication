using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Computer
{
    public class QueueTemplateV3<T>
    {
        public List<T> Item { get; set; }

        public QueueTemplateV3()
        {
            Item = new List<T>();
        }
        public void Enqueue(T i)
        {
            Item.Add(i);
        }

        public void Dequeue()
        {
            Item.RemoveAt(0);
        }
        
        public T GetValueAt0()
        {
            return Item[0];
        }

    }
}
