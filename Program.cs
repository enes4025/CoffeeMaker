using System;

namespace SingletonPattern
{
    static class Program
    {
        static void Main()
        {
            try
            {
                var coffeeBeans = CoffeeMaker.GetInstance();
                coffeeBeans.Fill();
                coffeeBeans.Boil();
                coffeeBeans.Drain();
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }
        }
    }
}
