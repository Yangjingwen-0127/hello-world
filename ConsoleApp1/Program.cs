using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new Student();
            stu.Name = "A";
            //stu.Sex = "男";
            Console.WriteLine(stu.Name);
            Console.WriteLine(stu.Sex);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
