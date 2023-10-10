using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cart
    {
        public List<Animal> AnimalCollection { get; private set; }

        public Animal LargestCarnivore { get; private set; }

        public int AnimalCount { get; private set; }

        public Cart() 
        {
            AnimalCount = 0;
            LargestCarnivore = null;
            AnimalCollection = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            if (!DoesAnimalFit(animal))
            {
                throw new Exception("Animal does not fit inside Cart.");
            }

            AnimalCollection.Add(animal);

            if (animal.Type == AnimalType.Carnivore)
            {
                LargestCarnivore = animal;
            }

            AnimalCount += (int)animal.Size;
        }

        public bool DoesAnimalFit(Animal animal)
        {
            if ((AnimalCount + (int)animal.Size) <= 10)
            {
                if (LargestCarnivore == null)
                {
                    return true;
                }
                else if (LargestCarnivore != null && (int)animal.Size > (int)LargestCarnivore.Size)
                {
                    return true;
                }
            }

            return false;
        }
        public override string ToString()
        {
            if(LargestCarnivore == null)
            {
                return "Cart Info, animal amount: " + AnimalCollection.Count + ", Current point count: " + AnimalCount;
            }
            else
            {
                return "Cart Info, animal amount: " + AnimalCollection.Count + ", Current point count: " + AnimalCount + ", Largest Carnivore: " + LargestCarnivore.Size;
            }
        }
    }
}
