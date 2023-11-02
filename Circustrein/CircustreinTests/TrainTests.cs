using Classes;

namespace CircustreinTests
{
    [TestClass]
    public class TrainTests
    {

        Animal largeCarnivore = new Animal(AnimalSize.Large, AnimalType.Carnivore);
        Animal MediumCarnivore = new Animal(AnimalSize.Medium, AnimalType.Carnivore);
        Animal SmallCarnivore = new Animal(AnimalSize.Small, AnimalType.Carnivore);
        Animal LargeHerbivore = new Animal(AnimalSize.Large, AnimalType.Herbivore);
        Animal MediumHerbivore = new Animal(AnimalSize.Medium, AnimalType.Herbivore);
        Animal SmallHerbivore = new Animal(AnimalSize.Small, AnimalType.Herbivore);

        [TestMethod]
        public void OnlyHerbivoresTrainTest()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();
            animals.Add(SmallHerbivore);
            animals.Add(SmallHerbivore);
            animals.Add(SmallHerbivore);
            animals.Add(SmallHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            train.SortAnimals(animals);
            //Assert.IsTrue(train._cartList.Count() == 4);
            //AreEqual geeft een duidelijkere antwoord terug, in de plaats van true/false krijg ik terug dat er 5 binnen zijn in plaats van de verwachte 4.
            Assert.AreEqual(4, train.GetCartList().Count());

            int animalCount = 0;
            List<Animal> checklist = new List<Animal>();
            foreach (Cart cart in train.GetCartList()) 
            {
                if(cart.AnimalCount == 0)
                {
                    Assert.Fail();
                }
                else
                {
                    foreach(Animal animal in cart.AnimalCollection)
                    {
                        checklist.Add(animal);
                        animalCount++;
                    }
                }
                
            }
            List<Animal> sortedChecklist = checklist.OrderByDescending(animal => animal.Type).ThenByDescending(animal => animal.Size).ToList();
            List<Animal> sortedAnimals = animals.OrderByDescending(animal => animal.Type).ThenByDescending(animal => animal.Size).ToList();
            for (int i = 0; i < animals.Count(); i++)
            {
                Assert.AreEqual(sortedChecklist[i], sortedAnimals[i]);
            }
            Assert.AreEqual(animalCount, animals.Count());
            //SortAnimals geeft een trein terug. Loop door deze trein via een foreach, check of de wagons correct zijn. of alle dieren goed ingevuld zijn. 
            //foreach()
        }
        [TestMethod]
        public void OnlyCarnivoresTrainTest()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(largeCarnivore);
            animals.Add(largeCarnivore);
            animals.Add(largeCarnivore);
            animals.Add(SmallCarnivore);
            animals.Add(SmallCarnivore);
            animals.Add(MediumCarnivore);
            train.SortAnimals(animals);
            Assert.IsTrue(train.GetCartList().Count() == 6);

            int animalCount = 0;
            List<Animal> checklist = new List<Animal>();
            foreach (Cart cart in train.GetCartList())
            {
                if (cart.AnimalCount == 0)
                {
                    Assert.Fail();
                }
                else
                {
                    foreach (Animal animal in cart.AnimalCollection)
                    {
                        checklist.Add(animal);
                        animalCount++;
                    }
                }

            }
            List<Animal> sortedChecklist = checklist.OrderByDescending(animal => animal.Type).ThenByDescending(animal => animal.Size).ToList();
            List<Animal> sortedAnimals = animals.OrderByDescending(animal => animal.Type).ThenByDescending(animal => animal.Size).ToList();
            for (int i = 0; i < animals.Count(); i++)
            {
                Assert.AreEqual(sortedChecklist[i], sortedAnimals[i]);
            }
            Assert.AreEqual(animalCount, animals.Count());
        }
        [TestMethod]
        public void BasicTrainTest()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(SmallHerbivore);
            animals.Add(SmallHerbivore);
            animals.Add(SmallHerbivore);
            animals.Add(SmallHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            train.SortAnimals(animals);
            Assert.IsTrue(train.GetCartList().Count() == 4);
        }
        [TestMethod]
        public void hardTrainTest()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(largeCarnivore);
            animals.Add(SmallHerbivore);
            animals.Add(SmallHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(SmallCarnivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumCarnivore);
            train.SortAnimals(animals);
            Assert.IsTrue(train.GetCartList().Count() == 4);
        }
        [TestMethod]
        public void ExpertTrainTest()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(largeCarnivore);
            animals.Add(largeCarnivore);
            animals.Add(SmallHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(LargeHerbivore);
            animals.Add(SmallCarnivore);
            animals.Add(SmallCarnivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumHerbivore);
            animals.Add(MediumCarnivore);
            train.SortAnimals(animals);
            Assert.IsTrue(train.GetCartList().Count() == 6);

            int animalCount = 0;
            List<Animal> checklist = new List<Animal>();
            foreach (Cart cart in train.GetCartList())
            {
                if (cart.AnimalCount == 0)
                {
                    Assert.Fail();
                }
                else
                {
                    Cart CarnivoreChecker = new Cart();
                    foreach (Animal animal in cart.AnimalCollection)
                    {
                        Assert.IsTrue(CarnivoreChecker.DoesAnimalFit(animal));
                        checklist.Add(animal);
                        CarnivoreChecker.AddAnimal(animal);
                        animalCount++;
                    }


                }

            }
            List<Animal> sortedChecklist = checklist.OrderByDescending(animal => animal.Type).ThenByDescending(animal => animal.Size).ToList();
            List<Animal> sortedAnimals = animals.OrderByDescending(animal => animal.Type).ThenByDescending(animal => animal.Size).ToList();
            for (int i = 0; i < animals.Count(); i++)
            {
                Assert.AreEqual(sortedChecklist[i], sortedAnimals[i]);
            }
            Assert.AreEqual(animalCount, animals.Count());
        }
    }
}