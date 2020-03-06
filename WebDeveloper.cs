using System;
public class WebDeveloper : Developer
{

    public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
    {

    }

    public void Develop()
    {
        Console.WriteLine("I developed using watching udemy videos");
    }

}