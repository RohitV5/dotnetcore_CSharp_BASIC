using System;
public class RetailSalesPerson : Salesman
{

    private int _age;
    // base refers to abstract classes constructor
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }


    
    public override void Sell()
    {
       Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this car",this.FullName));
    }
}