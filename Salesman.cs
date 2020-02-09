using System;
// This is a abstract class used by two types of salesman.
public abstract class Salesman
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
    public Salesman(string firstName, string lastName)
    {

        this._firstName = firstName;
        this._lastName = lastName;
    }

    // This is a method.
    public abstract void Sell();
    
    // When you dont override you can use this function from abstract class
    // its ok if you dont overrride a virtual method but you will have to implement abstract method in child class
    public virtual void Sell2(){
        Console.WriteLine(string.Format("Hi my name is {0}. I would super recommend you to buy this car",this.FullName));
    }
}