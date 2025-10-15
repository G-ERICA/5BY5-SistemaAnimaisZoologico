using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Animais_no_Zoológico
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) 
        { 
        }

        public override string Sound() 
        {
            return "Som: Au au";
        }

    }
}
