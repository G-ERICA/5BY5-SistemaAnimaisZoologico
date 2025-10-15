
using Sistema_de_Animais_no_Zoológico;

Animal[] animals = new Animal[3];

animals[0] = new Cat();
animals[1] = new Dog();
animals[2] = new Leon();

for (int i = 0; i < 3; i++)
{
    animals[i].Sound();
}
