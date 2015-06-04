using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
   public interface IPlay
    {
         string FileName { get; set; }
         void Stop();
        // void Play();
         void Pause();
    }
}
