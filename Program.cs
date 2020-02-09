using System;

namespace learn_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman steveTheSalesaman = new CarSalesman("Steve", "Roger");
            // the age is not used by abstract class
            RetailSalesPerson rohitTheBoss = new RetailSalesPerson("Rohit", "Verma",1);
            rohitTheBoss.Sell2();

            Console.WriteLine(steveTheSalesaman.FullName);
            steveTheSalesaman.Sell2();
            steveTheSalesaman.Develop();
        }
    }
}
