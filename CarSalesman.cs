using System;
public class CarSalesman
{
    // These are fields
    private string _firstName;
    private string _lastName;


    // this is a property
    public string FullName
    {
        get
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }
    
    
    //This is a constructor 
    public CarSalesman(string firstName, string lastName)
    {

        this._firstName = firstName;
        this._lastName = lastName;
    }

    // This is a method.
    public void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this car",this.FullName));
    }

}