using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
   public class PlayHepler
    {

       private Player oPlayer;
       public PlayHepler(string fileExtension)
       {
           if (fileExtension == "MP3")
           {
               oPlayer = new MP3Player();
           }
           else if (fileExtension == "WAV")
           {
               oPlayer = new WAVPlayer();
           }
       
       }

       public void Play()
       {
           oPlayer.Play();
       }

    }
}
