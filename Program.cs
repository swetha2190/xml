using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINKDEMO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select Your Choice\n 1.Add Employee\n2.Edit Employee\n 3.Delete\n4.Select All Employee\n5.Select By Id");
            int ch = Convert.ToInt32(Console.ReadLine());

            DataClasses1DataContext db = new DataClasses1DataContext();

           

            switch (ch)
            {
                //case 1:
                //    Console.WriteLine("insert empid,name,designation,managerid");
                //    int empid = Convert.ToInt32(Console.ReadLine());
                //    string empname = Console.ReadLine();
                //     string  designation = Console.ReadLine();
                //    int managerid = Convert.ToInt32(Console.ReadLine());

                //    Employee emp2 = new Employee() { employee_id = empid, designation = designation,
                //        employee_name = empname, manager_id = managerid };

                //    db.Employees.InsertOnSubmit(emp2);
                //    db.SubmitChanges();

                //    break;
                case 2:

                    Console.WriteLine("insert employee id");
                    int empid = Convert.ToInt32(Console.ReadLine());

                    Employee emp3 = (from e3 in db.Employees
                                     where e3.employee_id == empid
                                     select e3).Single();

                    Console.WriteLine("enter new  manager id");
                    int managerid = Convert.ToInt32(Console.ReadLine());

                    emp3.manager_id = managerid;
                    db.SubmitChanges();
                    break;
                case 3:


                    break;
                case 4:
                    List<Employee> emps = db.Employees.ToList();

                    foreach (var e1 in emps)
                    {
                        Console.WriteLine("{0} {1} {2} {3}",e1.employee_id,e1.employee_name,e1.designation,e1.manager_id);
                    }

                    break;
                case 5:
                    int id;
                    Console.WriteLine("enter employee id");
                    id = Convert.ToInt32(Console.ReadLine());

                    Employee e = db.Employees.Where(a => a.employee_id == id).Single();
                    Console.WriteLine("{0} {1} {2} {3}", e.employee_id, e.employee_name, e.designation, e.manager_id);



                    break;
                default:
                    Console.WriteLine("incorrect option");
                    break;
            }

            Console.ReadLine();
        }
    }
}
