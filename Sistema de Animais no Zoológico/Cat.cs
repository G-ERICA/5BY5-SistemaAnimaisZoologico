using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Animais_no_Zoológico
{
    internal class Cat : Animal
    {
        public override void Sound() 
        {
            Console.WriteLine("Gato: Miau");
        }

    }
}
