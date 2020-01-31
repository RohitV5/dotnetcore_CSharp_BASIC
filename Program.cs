using System;

namespace learn_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman steveTheSalesaman = new CarSalesman("Steve", "Roger");
            CarSalesman rohitTheBoss = new CarSalesman("Rohit", "Verma");
            rohitTheBoss.Sell();

            Console.WriteLine(steveTheSalesaman.FullName);
            steveTheSalesaman.Sell();
        }
    }
}
