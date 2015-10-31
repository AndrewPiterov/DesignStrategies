using System;
using DesignStrategies.Strategies;

namespace DesignStrategies.NullObject.App
{
    class Program
    {
        static void Main(string[] args)
        {

            var e = DB.GetEmployee("Bob");

            if (e.IsTimeToPay(DateTime.Now))
            {
                e.Pay();
            }

            Console.WriteLine("The End!");
            Console.ReadKey();
        }
    }
}
