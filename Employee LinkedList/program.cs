using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndNonGenericClasses
{
    internal class List
    {
    class EmployeeList
    {
            public int EmpId;
            public string EmpName;
            public int EmpSal;
            public string EmpLoc;


    }
 
        public static void Main()
        {
           List<EmployeeList> emp = new List<EmployeeList>();
           EmployeeList emp1 = new EmployeeList {EmpId=100,EmpName="John",EmpLoc="Hyderabad" };
           EmployeeList emp2 = new EmployeeList { EmpId = 101, EmpName = "Ram", EmpLoc = "Hyderabad" };
           EmployeeList emp3 = new EmployeeList { EmpId = 102, EmpName = "Smith", EmpLoc = "Goa" };
           EmployeeList emp4 = new EmployeeList { EmpId = 103, EmpName = "Tom", EmpLoc = "Hyderabad" };
            emp.Add(emp1);
            emp.Add(emp2);
            emp.Add(emp3);
            emp.Add(emp4);


            foreach(EmployeeList e in emp)
            {
                Console.WriteLine(e.EmpId+" "+e.EmpName+" "+e.EmpLoc);
            }




        }
    }
}
