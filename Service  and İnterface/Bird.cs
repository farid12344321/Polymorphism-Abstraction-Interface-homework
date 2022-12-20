using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service__and_İnterface
{
    internal abstract class Bird : Animal

    {
        public string Type { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
      
        
    }
}
