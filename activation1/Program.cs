using System;

namespace activation1
{
    class Outfit
    {
        string type = "Official shirt";
        string color = "Black";
        string name = "Gucii";
        string cost = "Kshs. 1000";
        string state = "Long-sleeved";
        string quality = "best";



        static void Main(string[] args)
        {
            Console.WriteLine("Description of my best Outfit, hope you'll like it");
            Outfit myObj1=new Outfit(); 
            Outfit myObj2= new Outfit();
            Outfit myObj3=new Outfit();
            Outfit myObj4=new Outfit();
            Outfit myObj5=new Outfit(); 
            Outfit myObj6=new Outfit(); 
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.name);
            Console.WriteLine(myObj3.cost);
            Console.WriteLine(myObj4.type);
            Console.WriteLine(myObj5.state);
            Console.WriteLine(myObj6.quality);
        }
    }
}
