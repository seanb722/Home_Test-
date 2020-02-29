using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace STT_Test1
{
    class Dog : Animal
    {
            public override string MakeNoice()
            {
                string noice = "woof";
                return noice;
            }
            public override int Legs()
            {
                int legs = 4;
                return legs;
            }
            /*public override toXML()
            {

            }*/
    }
}
