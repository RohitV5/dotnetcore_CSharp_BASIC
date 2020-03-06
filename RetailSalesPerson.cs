using System;
public class RetailSalesPerson : Salesman, SelfDeveloping
{

    private int _age;
    // base is a reserved keyword refers to abstract classes constructor which needs to be intialised before child class constructor
    // the parameter passed on to the child class constructor are passed on to the base class
    // the base class will not pick up the age parameter
    public RetailSalesPerson(string firstName, string lastName, int age) : base(firstName, lastName)
    {

        this._age = age;
    }



    // override can overrride abstract as well as cocrete method
    public override void Sell()
    {
        // the properties of the abstract class which are public are accessible in the child class
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this car", this.FullName));
    }



    public override void Sell2()
    {
        // overrding a virtual method. otherwise this function will have the definition from base class
        Console.WriteLine(string.Format("Hi my name is {0}. I would like you to buy this car", this.FullName));
    }


    public void Develop()
    {
        Console.WriteLine("I developed using watching videos");
    }





}