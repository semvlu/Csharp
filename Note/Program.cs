using Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// Value type: Refer to its value.
// int, float, char, struct
// e.g.
// int a = 1;
// int b = a;
// b = 3; (a = 1, b =3)

// Reference type: refer to its address.
// string, array, class
// e.g.
// class Car
// Car a = new Car();
// a.engine = "merc"
// Car b = a;
// b.engine = "ferrari" (a.engine = "ferrari", same for b)

// Array
// int[] a = new int[5];
// 2D
// int[,] a = {{1,2},{3,4},{5,6}};
// a.getLength(0); (0=row, 1=clmn)
// Jagged
// int[][] j = new int[][]
// {
// { 1,2,3,4 },
// { 5,6,7,8 },
// { 9,10,11,12 }
// };

// ArrayList
// Attribute: Capacity, Count
// Method: Add, RemoveAt
// e.g.
// ArrayList a = new ArrayList();
// for(int i = 0; i < a.Count; i++)
//     (( <class> )a[i].func());

// List (Generic)
// List <int> a = new List<int>();

// change data type (downcast)
//foreach (var ani in aniArr)
//{
//    MachineCat mcat = ani as MachineCat;
//    if (mcat != null)
//        mcat.ChangeThing()
//}



namespace Note
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
