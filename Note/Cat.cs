using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Note
{

    class Cat: Animal
    {
        new private static int amount = 0; // Cat.amount, not Animal.amount
        // Delegation
        public delegate void sDelegate();
        public sDelegate shoutDele;
        // Event 
        // 1. Declare a delegation
        public delegate void sEventHandler(object sender, sEventArgs args);
        // 2. Declare event var
        public event sEventHandler shoutEvent;
        // 3. Implement the method that's going to be tied to the event
        // private void method (object sender, sEventArgs <args>) { } // in other classes
        // 4. Tie the method to the event
        // shoutEvent += new sEventHandler(method) // NOT method(), see in Form.cs


        public Cat(string n):base(n)
        { 
            name = n;
            amount++;
        }
        ~Cat() { amount--; }


        // Whether using virtual or abstract
        // Always use override
        protected override string getShout() { return "Meow~"; }

        public void shout()
        {
            Console.WriteLine("Meow~");
            if (shoutDele != null)
            {
                foreach (sDelegate single in shoutDele.GetInvocationList())
                {//...
                    shoutDele();
                }
            }
                
            // OR
            sEventArgs e = new sEventArgs();
            e.Name = this.name;
            if (shoutEvent != null)
            {
                foreach (sEventHandler single in shoutEvent.GetInvocationList())
                { //...
                }
            }

        }

        public void Catch()
        {
            Console.WriteLine("老鼠別跑!");
        }

        public void removeAllEvent()
        {
            if (shoutDele == null)
                return;
            shoutDele = null;
        }

        // Static method
        // how to implement:
        // <class>.method(), NOT <object>.method()
        public static Cat breed(Cat _1, Cat _2)
        {
            Cat child = new Cat("baby");
            return child;
        }

        public static Cat operator *(Cat _1, Cat _2)
        {
            Cat child = new Cat("smooth operator");
            // result.re = _1.re*_2.re-_1.im*_2.im;
            // result.im = _1.re*_2.im+_1.im*_2.re;
            return child;
        }
    }

    class MachineCat : Cat, Magic
    {
        private string mys = "";
        public MachineCat(string n) : base(n) { }
        public string popUp() { return mys; }
    }

    public class sEventArgs: EventArgs
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
