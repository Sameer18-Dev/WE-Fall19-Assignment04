using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Assignment04
{

                                         /*   Assignment#4   */

    interface FTE
    {
        double calculateSalary(double bonus, double salary);
    }

    class FullTimeEpm : FTE
    {

        public double calculateSalary(double bonus, double salary)
        {
            return (bonus + salary);
        }
    }

    interface PTE
    {
        double calculateSalary(int hours, double salary);
    }

    class PartTimeEmp : PTE
    {

        public double calculateSalary(int hours, double salary)
        {
            return (hours * salary);
        }
    }

    // Child class 
    class Employee : FTE, PTE
    {       
        
        FullTimeEpm obj1 = new FullTimeEpm();

        PartTimeEmp obj2 = new PartTimeEmp();

        public double calculateSalary(int hours, double salary)
        {
            return (obj2.calculateSalary(hours, salary));
        }


        public double calculateSalary(double bonus, double salary)
        {
            return (obj1.calculateSalary(bonus, salary));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter size");
            //int N = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Assuming Their are Two Full-Time and Two Part-Time Employees");
            Console.WriteLine();

            Employee[] obj = new Employee[2];

            obj[0] = new Employee();
            obj[1] = new Employee();


            double totalsalary = 0;

            for(int i = 0; i<2; i++)
            {
                Console.WriteLine("Enter Full-Time  Employee Salary : ");
                int N = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Full-Time  Employee Bonus : ");
                int N2 = Int32.Parse(Console.ReadLine());
                totalsalary += obj[i].calculateSalary(Convert.ToDouble(N), Convert.ToDouble(N2));


                Console.WriteLine("Enter Part-Time  Employee Salary : ");
                N = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Part-Time  Employee Hours : ");
                N2 = Int32.Parse(Console.ReadLine());
                totalsalary += obj[i].calculateSalary(N, Convert.ToDouble(N2));
            }

            Console.WriteLine("Total Salary : "+totalsalary);

            Console.ReadLine();

        }
    }
}
