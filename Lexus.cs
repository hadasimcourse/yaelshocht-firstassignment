using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CR - remove all unused packages

namespace ConsoleApp2
{
    internal class Lexus:Car
    {
        public bool IsPlayingMusic { get; private set; } 
        //CR - why not private? also - why do you need a property if you created StartMusic() and StopMusic() for changing the value of this field?
        public Lexus(string model): base(model) {
            IsPlayingMusic = false;
        }
        public void StartMusic()
        {
            IsPlayingMusic = true;
        }

        public void StopMusic()
        {
            IsPlayingMusic = false;
        }
        public override void PrintDetails() 
        {
            base.PrintDetails();
          
        }

    }
}
