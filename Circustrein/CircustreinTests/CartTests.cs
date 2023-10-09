using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinTests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void AnimalIntoEmptyWagon()
        {
            Animal animal = new Animal(AnimalSize.Small, AnimalType.Carnivore);

            Cart cart = new Cart();
            Assert.IsTrue(cart.DoesAnimalFit(animal));
        }
        [TestMethod]
        public void CarnivoreIntoFittingCartTest()
        {
            Animal animal = new Animal(AnimalSize.Small, AnimalType.Carnivore);
            Animal Mediumherbi = new Animal(AnimalSize.Medium, AnimalType.Herbivore);
            Animal LargeHerbi = new Animal(AnimalSize.Large, AnimalType.Herbivore);

            Cart cart = new Cart();
            cart.TryAddAnimal(Mediumherbi);
            cart.TryAddAnimal(LargeHerbi);
            Assert.IsTrue(cart.DoesAnimalFit(animal));
        }
        [TestMethod]
        public void CarnivoreIntoWrongCartTest()
        {
            Animal animal = new Animal(AnimalSize.Small, AnimalType.Carnivore);
            Animal LargeCarni = new Animal(AnimalSize.Large, AnimalType.Carnivore);

            Cart cart = new Cart();
            cart.TryAddAnimal(LargeCarni);
            Assert.IsFalse(cart.DoesAnimalFit(animal));
        }
        [TestMethod]
        public void HerbivoreIntoFittingCartTest()
        {
            Animal animal = new Animal(AnimalSize.Large, AnimalType.Herbivore);
            Animal smallCarni = new Animal(AnimalSize.Small, AnimalType.Carnivore);

            Cart cart = new Cart();
            cart.TryAddAnimal(smallCarni);
            Assert.IsTrue(cart.DoesAnimalFit(animal));
        }
        [TestMethod]
        public void HerbivoreIntoWrongCartTest()
        {
            Animal animal = new Animal(AnimalSize.Small, AnimalType.Herbivore);
            Animal LargeCarni = new Animal(AnimalSize.Large, AnimalType.Carnivore);

            Cart cart = new Cart();
            cart.TryAddAnimal(LargeCarni);
            Assert.IsFalse(cart.DoesAnimalFit(animal));
        }
        [TestMethod]
        public void AnimalIntoFullCartTest()
        {
            Animal animal = new Animal(AnimalSize.Small, AnimalType.Carnivore);
            Animal LargeHerbi = new Animal(AnimalSize.Large, AnimalType.Herbivore);

            Cart cart = new Cart();
            cart.TryAddAnimal(LargeHerbi);
            cart.TryAddAnimal(LargeHerbi);
            Assert.IsFalse(cart.DoesAnimalFit(animal));
        }
        [TestMethod]
        public void PutAnimalIntoCorrectCartTest()
        {
            Animal animal = new Animal(AnimalSize.Small, AnimalType.Carnivore);

            Cart cart = new Cart();
            Assert.IsTrue(cart.TryAddAnimal(animal));
        }
    }
}
