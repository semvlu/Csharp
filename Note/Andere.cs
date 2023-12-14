using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Andere
    {
        // call by reference
        void swap (ref int _1, ref int _2)
        {
            int tmp = _1;
            _1 = _2;
            _2 = tmp;
        }
    }
}
