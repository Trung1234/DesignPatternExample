using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
   public class Player : IPlay
    {

        private string _fileName;
        public string FileName
        {
            get
            {
               return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public virtual void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }
    }
}
