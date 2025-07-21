using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
// a pseudo-code method to randomize the petting zoo animals
void RandomizeAnimals()
{
    int i = 0;
    int r = 1;

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;

    System.Console.WriteLine(pettingZoo[i] + " " + pettingZoo[r]);
    System.Console.WriteLine(temp);

}

RandomizeAnimals();
// string[ , ] group = AssignGroup();

Console.WriteLine("Shool A\n");


// Example of how to assign animals to groups
// PrintGroup(group);
