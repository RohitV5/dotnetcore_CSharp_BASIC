using System;

public class CarSalesman : Salesman, SelfDeveloping
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }


    public override void Sell(){
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this car",this.FullName));
    }

    // We are extending an interface and absract class both above..wow. 
    public void Develop(){
        // this method must be implemented in a way described in interface SelfDeveloping i.e the wether it should be private, public, what the return type will be.
        // if its not mentioned then we can return any type and make it private or public etc.
        Console.WriteLine("Line of code written today {0}",this.LinesOfCode());
    }

    private  int LinesOfCode(){
        // this function is in the contract which tells us to return an integer, doesnt tell if this should be private or public so its upto us
        return 0;
    }
}