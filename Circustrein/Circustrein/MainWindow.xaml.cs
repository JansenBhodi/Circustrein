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
        List<Animal> Animals = new List<Animal>();
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
            Animals.Clear();
            LbView.ItemsSource = null;
            Animals.Add(largeCarnivore);
            Animals.Add(SmallHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(SmallCarnivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumCarnivore);
            Train train = new Train().SortAnimals(Animals);
            LbView.ItemsSource = train.GetCartList();
        }
        private void BtnPreset2(object sender, RoutedEventArgs e)
        {
            Animals.Clear();
            LbView.ItemsSource = null;
            Animals.Add(largeCarnivore);
            Animals.Add(SmallHerbivore);
            Animals.Add(SmallHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(SmallCarnivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumCarnivore);
            Train train = new Train().SortAnimals(Animals);
            LbView.ItemsSource = train.GetCartList();

        }
        private void BtnPreset3(object sender, RoutedEventArgs e)
        {
            Animals.Clear();
            LbView.ItemsSource = null;
            Animals.Add(largeCarnivore);
            Animals.Add(largeCarnivore);
            Animals.Add(SmallHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(SmallCarnivore);
            Animals.Add(SmallCarnivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumCarnivore);
            Train train = new Train().SortAnimals(Animals);
            LbView.ItemsSource = train.GetCartList();

        }
        private void BtnPreset4(object sender, RoutedEventArgs e)
        {
            Animals.Clear();
            LbView.ItemsSource = null;
            Animals.Add(SmallHerbivore);
            Animals.Add(SmallHerbivore);
            Animals.Add(SmallHerbivore);
            Animals.Add(SmallHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(LargeHerbivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumHerbivore);
            Animals.Add(MediumHerbivore);
            Train train = new Train().SortAnimals(Animals);
            LbView.ItemsSource = train.GetCartList();

        }
        private void BtnPreset5(object sender, RoutedEventArgs e)
        {
            Animals.Clear();
            LbView.ItemsSource = null;
            Animals.Add(largeCarnivore);
            Animals.Add(largeCarnivore);
            Animals.Add(largeCarnivore);
            Animals.Add(SmallCarnivore);
            Animals.Add(SmallCarnivore);
            Animals.Add(MediumCarnivore);
            Train train = new Train().SortAnimals(Animals);
            LbView.ItemsSource = train.GetCartList();

        }
    }
}
