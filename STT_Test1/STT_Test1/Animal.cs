using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace STT_Test1
{
    public abstract class Animal
    {
        public abstract int Legs();
        public abstract string MakeNoice();
        //public abstract string ToXML();

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.MakeNoice());
            Console.WriteLine(dog.Legs());

            Duck duck = new Duck();
            Console.WriteLine(duck.MakeNoice());
            Console.WriteLine(duck.Legs());
            Console.Read();
            XDocument xDox = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XElement("Animal"),
               new XElement("Dog",
                   new XAttribute("Number of legs", "Noice it makes"),
               new XElement("Duck",
                   new XAttribute("Number of legs", "Noice it makes")
                   )
               )
           );
            xDox.Save("C:/Users/Sean/source/repos/STT_Test1/XMLdoc.xml");

        }
    }
  
}
