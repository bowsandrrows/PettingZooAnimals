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
Random random = new ();

for (int i = 0; i < pettingZoo.Length; i++) 
{
    int r = random.Next(pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
}

}

RandomizeAnimals();
// string[ , ] group = AssignGroup();

Console.WriteLine("Shool A\n");


// Example of how to assign animals to groups
// PrintGroup(group);
