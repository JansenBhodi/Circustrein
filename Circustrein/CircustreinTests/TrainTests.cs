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
            Train train = new Train();
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.SortAnimals();
            //Assert.IsTrue(train._cartList.Count() == 4);
            //AreEqual geeft een duidelijkere antwoord terug, in de plaats van true/false krijg ik terug dat er 5 binnen zijn in plaats van de verwachte 4.
            Assert.AreEqual(4, train.GetCartList().Count());
            
            //SortAnimals geeft een trein terug. Loop door deze trein via een foreach, check of de wagons correct zijn. of alle dieren goed ingevuld zijn. 
            //foreach()
        }
        [TestMethod]
        public void OnlyCarnivoresTrainTest()
        {
            Train train = new Train();
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(MediumCarnivore);
            train.SortAnimals();
            Assert.IsTrue(train.GetCartList().Count() == 6);
        }
        [TestMethod]
        public void BasicTrainTest()
        {
            Train train = new Train();
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.SortAnimals();
            Assert.IsTrue(train.GetCartList().Count() == 4);
        }
        [TestMethod]
        public void hardTrainTest()
        {
            Train train = new Train();
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumCarnivore);
            train.SortAnimals();
            Assert.IsTrue(train.GetCartList().Count() == 4);
        }
        [TestMethod]
        public void ExpertTrainTest()
        {
            Train train = new Train();
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumCarnivore);
            train.SortAnimals();
            Assert.IsTrue(train.GetCartList().Count() == 6);
        }
    }
}