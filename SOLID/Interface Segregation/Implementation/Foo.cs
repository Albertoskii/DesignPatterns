using Interface_Segregation.Implementation.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Implementation
{
    public class Foo
    {
        public Foo(int a, int b, bool c = false, int d = 42, float e = 1.0f)
        {
            // meaningful code here
        }
        public Foo(MyParams myparams)
        {

        }
    }
}
