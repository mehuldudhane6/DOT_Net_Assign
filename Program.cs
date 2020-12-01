using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Akash", 123465, 10);
            o1.getNetSalary();
            Employee o2 = new Employee("Akshay", 13536623344);
            o2.getNetSalary();
            Employee o3 = new Employee("amol");
            o3.getNetSalary();
            Employee o4 = new Employee();
            o4.getNetSalary();
            Employee o5 = new Employee("mehul", 163465, -1);
            o5.getNetSalary();
            Console.WriteLine(o1.Empno);
            Console.WriteLine(o2.Empno);
            Console.WriteLine(o3.Empno);
            Console.WriteLine(o4.Empno);
            Console.WriteLine(o5.Empno);
            Console.WriteLine("======================++");
            Console.WriteLine(o4.Empno);
            Console.WriteLine(o3.Empno);
            Console.WriteLine(o2.Empno);
            Console.WriteLine(o1.Empno);
            Console.WriteLine(o5.Empno);
        }
    }

    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private short deptNo;
        private static int count = 0;
        public double incomeTax = 0.5;
        public double pTax = 0.6;


        public Employee()
        {
            count++;
            this.Name = " ";
            this.empNo = count;
        }
        public Employee(String n, decimal b, short d)
        {
            count++;
            this.empNo = count;
            this.Name = n;
            this.Basic = b;
            this.DeptNo= d;
        }

        public Employee(String name, decimal basic)
        {
            count++;
            this.empNo = count;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = 0;

        }
        public Employee(String name)
        {
            count++;
            this.empNo = count;
            this.Name = name;
            this.Basic = 0;
            this.DeptNo = 0;
        }
        public string Name
        {
            set {
                if (value == " " || value == null)
                {
                    Console.WriteLine("plz...enter some value");
                }
                else {
                    name = value;
                }
            }

            get {
                return name;
            }
        }

        public int Empno
        {
            get {
                return empNo;
            }
        }

        public decimal Basic
        {
            set
            {
                if (value>10000)
                {
                    
                    basic = value;
                }
                else
                {
                    Console.WriteLine("enter value greater than 10000");
                }
            }

            get
            {
                return basic;
            }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                {

                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("deprt no. should be greater than 0");
                }
            }

            get
            {
                return deptNo;
            }
        }


        public void  getNetSalary()
        {
            double salary = (double)this.Basic + ((double)this.Basic * incomeTax) - ((double)this.Basic * pTax);
            
            Console.WriteLine("net salary="+salary);
        }
     
    }
}
