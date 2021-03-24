using System;

namespace SingletonPattern
{
    internal partial class CoffeeMaker
    {
        private static readonly Lazy<CoffeeMaker> _singleton = new Lazy<CoffeeMaker>(() => new CoffeeMaker());

        public static CoffeeMaker GetInstance() => _singleton.Value;

        private Status _boiler;

        private CoffeeMaker()
        {
            Console.WriteLine("Starting");
            _boiler = Status.Empty;
        }

        public void Fill()
        {
            if (!IsEmpty) return;
            Console.WriteLine("Filling...");
            _boiler = Status.InProgress;
        }

        public void Drain()
        {
            if (!IsBoiled) return;
            Console.WriteLine("Draining...");
            _boiler = Status.Empty;
        }

        public void Boil()
        {
            if (IsBoiled || IsEmpty) return;
            Console.WriteLine("Boiling...");
            _boiler = Status.Boiled;
        }

        private bool IsEmpty => (_boiler == Status.Empty);

        private bool IsBoiled => (_boiler == Status.Boiled);
    }
}
