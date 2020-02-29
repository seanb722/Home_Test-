using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STT_Test1
{
    class Duck : Animal
    {
        public override string MakeNoice()
        {
            string noice1 = "Quack";
            return noice1;
        }
        public override int Legs()
        {
            int legs1 = 2;
            return legs1;
        }
        /*public override toXML()
        {

        }*/
    }
}
