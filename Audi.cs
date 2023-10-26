using System;



namespace ConsoleApp2
{
  
     class Audi:Car 
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
