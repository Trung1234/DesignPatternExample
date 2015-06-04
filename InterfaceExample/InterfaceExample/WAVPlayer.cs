using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
   public class WAVPlayer : Player
    {
       public override void Play()
       {
           Console.WriteLine("WAVPlay");
       }

    }
}
