using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;
            b++;
            Console.WriteLine($"a je {a} a b je {b}");

            Neka ao = new();
            ao.broj = 5;
            Neka bo = ao;
            bo.broj++;
            ao.broj++;
            Console.Write($"a je {ao.broj} a b je {bo.broj}");
        }
    }
    class Neka
    {
        public int broj;
    }

}
