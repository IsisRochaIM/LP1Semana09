using System;
using System.Linq;

namespace AnimalKingdom
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Animal [] animals = new Animal[10];
            Random random = new Random();
            for(int i = 0; i < animals.Length; i++)
            {
                 int anType = random.Next(1, 5);
                if(anType == 1)
                {
                    animals[i] = new Bat();
                }
                if(anType == 2)
                {
                    animals[i] = new Cat();
                }
                if(anType == 1)
                {
                    animals[i] = new Dog();
                }
                if(anType == 1)
                {
                    animals[i] = new Bee();
                }
            }
            foreach(Animal a in animals)
            {
               Console.WriteLine(a.Sound());
               if(a is ICanFly)
                {
                    Console.WriteLine()
                }
            }
        }
    }
}
