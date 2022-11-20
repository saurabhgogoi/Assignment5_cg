using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndNonGenericClasses
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                    new Employee{EmpId=1,EmpName="A",EmpSal=20000,EmpLoc="Hyd"},
                    new Employee{EmpId=2,EmpName="B",EmpSal=25000,EmpLoc="Hyd"},
                    new Employee{EmpId=3,EmpName="C",EmpSal=32000,EmpLoc="Hyd"},
                    new Employee{EmpId=3,EmpName="D",EmpSal=40000,EmpLoc="Hyd"},
                    new Employee{ EmpId=4, EmpName="E"},
            };
            foreach (Employee i in al)
            {
                Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);
            }
            Console.ReadKey();
        }
    }
}
