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
    
}