using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Mouse: Animal
    {
        // Delegation
        public delegate void EventDelegate();
        public EventDelegate runDele;

        public void run()
        {
            Console.WriteLine("貓來了，快跑!");
            if (runDele != null)
                runDele();
        }
    }
}
