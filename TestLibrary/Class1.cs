using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Test
    {
        private static int i = 10;
        
        private int j=10;
        public static int TestFunction()
        {
            return i;
        }

        public int TestNonStatic()
        {
            i++;
            j++;
            //line of codes
            
            return j;
        }
    }
}
