
using Sistema_de_Animais_no_Zoológico;

Animal[] animals = new Animal[3];

animals[0] = new Cat("Tom", 3);
animals[1] = new Dog("Coragem", 5);
animals[2] = new Leon("Simba", 7);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(animals[i].ToString());
    Console.WriteLine(animals[i].Sound());
    Console.WriteLine("----------------");
}


