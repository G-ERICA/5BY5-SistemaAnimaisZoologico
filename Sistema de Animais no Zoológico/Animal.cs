using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Animais_no_Zoológico
{
    public abstract class Animal
    {
        private string? Name { get; set; }
        private int Age { get; set; }


        public string GetName(string name)
        {
            return this.Name = name;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public Animal(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"nome: {this.Name}\nIdade: {this.Age}";
        }

        public abstract string Sound();               
    }
}
