using System;

namespace learn_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDeveloper mike = new WebDeveloper("Angular 6");
            mike.Code();
            mike.Develop();
            mike.Code("Origami");

        }
    }
}
