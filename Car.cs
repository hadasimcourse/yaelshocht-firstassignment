using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//CR - remove all unused packages
//CR - where is your Program.cs file? this is the main .cs file from where we can run our program.

namespace ConsoleApp2 //CR - naming - give the project a relevant name
{
    internal class Car
    {  public string Model { get; set; } //CR - why public? We need to be careful in maintaining the privacy of variables
        public int Speed { get;  set; }
      
        public Car(string model)
        {
            Model = model;
            Speed = 0;
        }

      



        public virtual void Accelerate(int accelerate)
        {
            Speed += accelerate;
        }

        public virtual void Decelerate(int decelerate)
        {
            Speed -= decelerate;
        }

        public void Stop()
        {
            Speed = 0;
        }

       

       

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Speed: {Speed}");
            

        } } } //CR - formatting (you should read about linting in C#)

     

