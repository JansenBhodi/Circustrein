using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cart
    {
        private List<Animal> AnimalCollection;

        private Animal LargestCarnivore;

        private int AnimalCount;

        Cart() 
        {
            AnimalCount = 0;
            AnimalCollection = new List<Animal>();
        }
    }
}
