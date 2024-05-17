
using System;

namespace CSharpFundamental
{
    class Program : Program4
    {
        String name;
        String lname;
        public Program(String name) 
        {
            this.name = name;
        }

        public Program(String fname, String lname)
        {
            this.name = fname;
            this.lname = lname;
        }

        public void getName()
        {
            Console.WriteLine("My name is" +this.name);
            Console.WriteLine(this.name + this.lname);
        }

        public void getData()
        {
            Console.WriteLine("I am inside te method");
        }

        static void Main(string[] args)
        {
            Program p = new Program("Yogesh");
            Program p1 = new Program("Yogesh", "Khanse");

            p.getData();
            p.getName();
            p1.getName();
            p.SetData();

            Console.WriteLine("Hello, World!");
            int a = 4;
            Console.WriteLine("Number is " + a);

            string name = "Yogesh";
            Console.WriteLine("Name is " + name);

            var age = "23";
            Console.WriteLine("Age is " + age);

            dynamic hright = "13.5";
            Console.WriteLine("Hright is" + hright);

            hright = "Thirteen";
            Console.WriteLine("Hright is " + hright);
        }
    }
}
