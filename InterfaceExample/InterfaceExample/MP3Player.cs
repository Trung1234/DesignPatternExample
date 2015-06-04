using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class MP3Player:Player
    {
        public override void Play()
        {   
            Console.WriteLine("MP3Play");
        }
    }
}
