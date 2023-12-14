using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Animal
    {
        protected string name;
        protected int shoutNr;
        protected static int amount = 0;

        // Constructor
        public Animal() 
        {
            name = "";
            amount++;
        }
        public Animal(string n) 
        { 
            name = n;
            amount++;
        }

        // Attribute
        public string Name { 
            get { return name; } 
            set { name = value; }
            // how to implement:
            // string s = a.Name;
            // a.Name = "random";
        }

        public static Animal Create(string n, int s)
        {
            Animal a = null;
            if (s <= 0)
                return a;
            else{
                a = new Animal(n);
                return a;
            }
        }

        // Polymorphism & Reconstruction
        public string shout()
        {
            string s = "";
            for (int i = 0; i < shoutNr; i++)
                s += getShout();
            return s;

        }
        protected virtual string getShout() { return ""; }
        // Abstraction
        // Abstract class cannot be embodied
        // Abstract method has only declaration, no def
        //protected abstract string getShout();

        // Destructor
        ~Animal() { amount--; }
        // how to implement:
        // aArr[i] = null;
        // GC.Collect();
        // GC.WaitForPendingFinalizers();
        // aArr.RemoveAt(i);



    }


    interface Magic
    {
        // Like abstract
        // Only declaration, no def
        string popUp();
    }

}

