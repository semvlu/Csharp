using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class Form1 : Form
    {
        List<Animal> arr = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerEvent()
        {
            foreach (Animal mAni in arr)
            {
                if (mAni is MachineCat)
                {
                    MachineCat mCat = (MachineCat)mAni;
                    mCat.removeAllEvent();
                    foreach(Animal ani in arr)
                    {
                        if ((ani is Cat) && !(ani is MachineCat))
                        {
                            Cat cat = ani as Cat;
                            mCat.shoutDele += new MachineCat.sDelegate(method);
                        }
                    }
                }
            }

            // OR
            foreach (Animal mAni in arr)
            {
                if (mAni is MachineCat)
                {
                    MachineCat mCat = (MachineCat)mAni;
                    mCat.removeAllEvent();
                    foreach (Animal ani in arr)
                    {
                        if ((ani is Cat) && !(ani is MachineCat))
                        {
                            Cat cat = ani as Cat;
                            mCat.shoutEvent += new MachineCat.sEventHandler(method);
                        }
                    }

                }
            }
        }

        private void egTypeChng()
        // as: t->obj ref, f->null
        // is: t->true, f->false
        {
            foreach (var a in arr) 
            {
                MachineCat mcat = a as MachineCat;
                if(mcat != null)
                    mcat.popUp();
            }
        }
    }
}
