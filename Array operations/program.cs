using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndNonGenericClasses
{
    class Arrays
    {
        public static void Main()
        {
            int[] MyIntArray= new int[5];
            string[] MyStringArray = new string[5];
            MyIntArray[0] = 10;
            MyIntArray[1] = 20;
            MyIntArray[2] = 30;
            MyIntArray[3] = 40;
            MyIntArray[4] = 50;
            MyStringArray[0]=  "Sun";
            MyStringArray[1] = "Mon";
            MyStringArray[2] = "Tue";
            MyStringArray[3] = "Wed";
            MyStringArray[4] = "Thu";





            Console.WriteLine("The Elements in the array are:");
            foreach (int i in MyIntArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The Elements in the array are:");
            foreach (string s in MyStringArray)
            {
                Console.WriteLine(s);
            }
            int[] NewMyIntArray=new int[5];
            string[] NewMyStringArray=new string[5];
            Array.Copy(MyIntArray, NewMyIntArray, 5);
            Array.Copy(MyStringArray, NewMyStringArray, 5);
            Console.WriteLine("The Elements in the array after copying are:");
            foreach (int i in NewMyIntArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The Elements in the array after copying are:");
            foreach (string s in NewMyStringArray)
            {
                Console.WriteLine(s);
            }
           

            Array.Sort(NewMyIntArray);
            Array.Sort(NewMyStringArray);
            Console.WriteLine("The Elements in the array after sorting are:");
            foreach (int i in NewMyIntArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The Elements in the array after sorting are:");

            foreach (string s in NewMyStringArray)
            {
                Console.WriteLine(s);
            }
            Array.Reverse(NewMyIntArray);
            Array.Reverse(NewMyStringArray);

            Console.WriteLine("The Elements in the array after reversing are:");
            foreach (int i in NewMyIntArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The Elements in the array after reversing are:");

            foreach (string s in NewMyStringArray)
            {
                Console.WriteLine(s);
            }

            Array.Clear(NewMyIntArray,0,2);
            Array.Clear(NewMyStringArray,0,2);
            Console.WriteLine("The Elements in the array after clearing are:");
            foreach (int i in NewMyIntArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The Elements in the array after clearing are:");
            foreach (string s in NewMyStringArray)
            {
                Console.WriteLine(s);
            }
           



        }
    }
}
