using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service__and_İnterface
{
    internal abstract class Animal
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Color { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
        public abstract void Eating();
        

        
    }
}
