using System;
public class RetailSalesPerson : Salesman, SelfDeveloping
{


    // base is a reserved keyword refers to abstract classes constructor which needs to be intialised before child class constructor
    // the parameter passed on to the child class constructor are passed on to the base class
    // the base class will not pick up the age parameter
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {


    }



    // override can overrride abstract as well as marked virtual method
    // public override void Sell()
    // {
    //     // the properties of the abstract class which are public are accessible in the child class
    //     Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this pen", this.FullName));
    // }



    public override void Sell2()
    {
        // overrding a virtual method. otherwise this function will have the definition from base class
        Console.WriteLine(string.Format("Hi my name is {0}. I would like you to buy this pen", this.FullName));
    }


    public void Develop()
    {
        Console.WriteLine("I developed using watching videos");
    }



    protected override void Engage()
    {
        Console.WriteLine("Hello");
    }
    protected override void EstablishTrust()
    {
        Console.WriteLine("I just want to quickly help you");
    }
    protected override void AddressConcern()
    {
        Console.WriteLine("Everything is discounted 50%");
    }
    protected override void DemoValue()
    {
        Console.WriteLine("Our customers love it");
    }
    protected override void Close()
    {
        Console.WriteLine("Buy this pen");
    }





}