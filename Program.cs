using System;
using System.Collections.Generic;

namespace learn_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman carSalesman1 = new CarSalesman("James", "Maddison");
            carSalesman1.Sell();

            CarSalesman carSalesman2 = new CarSalesman("Thiery", "Henry");
            carSalesman2.Sell();

            RetailSalesPerson retailSalesPerson1 = new RetailSalesPerson("Luka", "Poldi");
            retailSalesPerson1.Sell();


            //Dynamic Polymorphism implements the above thing 
            List<Salesman> salesmen = new List<Salesman>() { new CarSalesman("James", "Maddison"), new CarSalesman("Thiery", "Henry"), new RetailSalesPerson("Luka", "Poldi"), new InsuranceBroker("Luka", "jovic") };

            foreach (var item in salesmen)
            {
                showMeHowToSell(item);
            }

        }

        static void showMeHowToSell(Salesman salesman)
        {
            salesman.Sell();
        }
    }
}
