using System;

namespace Type_3__out_parameter
{
    class Program
    {
        static void show(out int x,out int y)
        {
            
            Console.Write("Enter the value :");
            int num = int.Parse(Console.ReadLine());
            x = num * num;
            y = num * num * num;
            Console.WriteLine("first :"+x+" "+y);
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            show( out a,out b);
            Console.WriteLine("Last :"+a+" "+b);
        }
    }
}
