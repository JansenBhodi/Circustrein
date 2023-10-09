using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Circustrein
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Train train = new Train();
        Animal largeCarnivore = new Animal(AnimalSize.Large, AnimalType.Carnivore);
        Animal MediumCarnivore = new Animal(AnimalSize.Medium, AnimalType.Carnivore);
        Animal SmallCarnivore = new Animal(AnimalSize.Small, AnimalType.Carnivore);
        Animal LargeHerbivore = new Animal(AnimalSize.Large, AnimalType.Herbivore);
        Animal MediumHerbivore = new Animal(AnimalSize.Medium, AnimalType.Herbivore);
        Animal SmallHerbivore = new Animal(AnimalSize.Small, AnimalType.Herbivore);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPreset1(object sender, RoutedEventArgs e)
        {
            train.Reset();
            LbView.ItemsSource = null;
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(SmallHerbivore);
            train.AddAnimal(LargeHerbivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(MediumHerbivore);
            train.AddAnimal(MediumCarnivore);
            train.SortAnimals();
            LbView.ItemsSource = train._cartList;
        }
        private void BtnPreset2(object sender, RoutedEventArgs e)
        {
            train.Reset();
            LbView.ItemsSource = null;
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
            LbView.ItemsSource = train._cartList;

        }
        private void BtnPreset3(object sender, RoutedEventArgs e)
        {
            train.Reset();
            LbView.ItemsSource = null;
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
            LbView.ItemsSource = train._cartList;

        }
        private void BtnPreset4(object sender, RoutedEventArgs e)
        {
            train.Reset();
            LbView.ItemsSource = null;
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
            LbView.ItemsSource = train._cartList;

        }
        private void BtnPreset5(object sender, RoutedEventArgs e)
        {
            train.Reset();
            LbView.ItemsSource = null;
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(largeCarnivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(SmallCarnivore);
            train.AddAnimal(MediumCarnivore);
            train.SortAnimals();
            LbView.ItemsSource = train._cartList;

        }
    }
}
