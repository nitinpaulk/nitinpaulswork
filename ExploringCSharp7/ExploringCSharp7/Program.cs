using System;
using System.ComponentModel;
using System.Data;

namespace ExploringCSharp7
{
    class Program
    {
        // Declaring a methond with ref parameters.
        // In this case the reg variables will need to be initialised
        public void Math(int a, int b, ref int c, ref int d)
        {
            c = a + b;
            d = a * c;
        }

        public void Math2(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * c;
        }

        static void Main(string[] args)
        {
            int m = 10, n = 20;
            int x=0, y=0;
            Program obj = new Program();
            obj.Math(m,n, ref x, ref y);
            Console.WriteLine("The Sum us {0} and the product is {1}", x,y);

            Console.WriteLine("---------------------");

            obj.Math2(m,n, out int c, out int d); // This is the new way of decleration of variables. No need to declare separately
            Console.WriteLine("Values using the C# 7 are {0} and {1}", c, d);

            Console.WriteLine("---------------------");
            Tuples tuples = new Tuples();
            var tupleresult = tuples.Math(m, n);
            Console.WriteLine("Values using tuples are Sum : {0} and Product : {1}", tupleresult.sum, tupleresult.product);

            Console.WriteLine("---------------------");
            DeconstructorUsage objDeconstructorUsage = new DeconstructorUsage(1001, "Nitin", "Scon", 150000);
            var (Eno, Ename, EDesig, Esal) = objDeconstructorUsage;
            Console.WriteLine("Employee details are : ");
            Console.WriteLine("Employee Number : ", Eno);
            Console.WriteLine("Employee Name : ", Ename);
            Console.WriteLine("Employee Designation : ", EDesig);
            Console.WriteLine("Employee Salary : ", Esal);

            Console.ReadLine();


        }
    }
}
