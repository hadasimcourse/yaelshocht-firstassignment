using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CR - remove all unused packages

namespace ConsoleApp2
{
    //CR - good! keep using OOP.
    //CR - why do you use internal class?
    internal class Audi:Car 
    {
        public Audi(string model) : base(model) { }

        public override void Accelerate(int acceleration)
        {
        base.Accelerate(acceleration*2);

        }
        public override void PrintDetails()
        {
            base.PrintDetails();    
        }
    }
}
