using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Implementation.Params
{
    public class MyParams
    {
        public int a;
        public int b;
        public bool c = false;
        public int d = 42;
        public float e = 1.0f;

        public MyParams(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
