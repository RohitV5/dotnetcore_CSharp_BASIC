using System;


public abstract class Developer
{

    public string _mainDevLanguage;

    public Developer(string mainDevLanguage)
    {
        this._mainDevLanguage = mainDevLanguage;
    }


    // public virtual void Code(string firstExtraDevlanguage=null, string secondExtraDevlanguage=null)
    // {
    //     if(firstExtraDevlanguage==null && secondExtraDevlanguage ==null)
    //     {
    //         Console.WriteLine(string.Format("I am coding using my main dev language {0}", this._mainDevLanguage));
    //     }else if(firstExtraDevlanguage!=null && secondExtraDevlanguage !=null)
    //     {
    //         Console.WriteLine(string.Format("I am coding using my main dev language {0}. Additionally {1} and {2}", this._mainDevLanguage, firstExtraDevlanguage, secondExtraDevlanguage));
    //     }
    //     else if(firstExtraDevlanguage != null)
    //     {
    //         Console.WriteLine(string.Format("I am coding using my main dev language {0}. Additionally {1} ", this._mainDevLanguage, firstExtraDevlanguage));
    //     }        
    //     else if(secondExtraDevlanguage !=null)
    //     {
    //         Console.WriteLine(string.Format("I am coding using my main dev language {0}. Additionally {1} ", this._mainDevLanguage, secondExtraDevlanguage));
    //     }

    // }

    // The virtual keyword is used to modify a method ,property,or event declared in the base class to be overridden in the derived class
    // The new keyword is used to hide a method, property, indexer or event of base class into derived class
    // Using static polymorphism same name of function but based on parameters specific one will be called
    // Static polymorphism - different numbers, different types, different order
    public virtual void Code()
    {

        Console.WriteLine(string.Format("I am coding using my main dev language {0}", this._mainDevLanguage));


    }


    public virtual void Code(string firstExtraDevlanguage, string secondExtraDevlanguage)
    {
        Console.WriteLine(string.Format("I am coding using my main dev language {0}. Additionally {1} and {2}", this._mainDevLanguage, firstExtraDevlanguage, secondExtraDevlanguage));


    }


    public virtual void Code(string extraDevlanguage)
    {

        Console.WriteLine(string.Format("I am coding using my main dev language {0}. Additionally {1} ", this._mainDevLanguage, extraDevlanguage));


    }

}


