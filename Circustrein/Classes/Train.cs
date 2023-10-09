using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Train
    {
        public List<Cart> _cartList { get; private set; }
        public List<Animal> _allAnimals { get; private set; }

        public Train()
        {
            _cartList = new List<Cart>();
            Cart cart = new Cart();
            _cartList.Add(cart);
            _allAnimals = new List<Animal>();
        }

        public Train CreateTrain()
        {
            Train train = new Train();

            return train;
        }


        public void SortAnimals()
        {
            #region V1
            ////Using Linq to sort animal list (requires another list to sort it into.
            ////sorting order. From Large to Small, Each size starts with carnivore's first.
            //List<Animal> Animals = _allAnimals.OrderByDescending(o => o.Type).ThenByDescending(o => o.Size).ToList();

            ////Using the Sort function.
            ////_allAnimals.Sort((x, y) => x.Size.CompareTo(y.Size));

            ////Sort all animals in list between carts
            //foreach (Animal animal in Animals)
            //{
            //    try
            //    {
            //        if (animal.Size == AnimalSize.Large && animal.Type == AnimalType.Carnivore)
            //        {
            //            try
            //            {
            //                if (_cartList.Last().DoesAnimalFit(animal))
            //                {
            //                    _cartList.Last().TryAddAnimal(animal);
            //                    Cart newCart = new Cart();
            //                    _cartList.Add(newCart);
            //                }
            //                else
            //                {
            //                    break;
            //                }
            //            }
            //            catch (Exception)
            //            {

            //                throw;
            //            }
            //        }
            //        else if (animal.Type == AnimalType.Carnivore)
            //        {
            //            try
            //            {
            //                bool NewCartRequired = true;
            //                foreach (Cart cart in _cartList)
            //                {
            //                    if (cart.DoesAnimalFit(animal))
            //                    {
            //                        NewCartRequired = false;
            //                        cart.TryAddAnimal(animal);
            //                        break;
            //                    }
            //                }
            //                if(NewCartRequired == true)
            //                {
            //                    Cart newCart = new Cart();
            //                    newCart.TryAddAnimal(animal);
            //                    _cartList.Add(newCart);
            //                }
            //            }
            //            catch (Exception)
            //            {

            //                throw;
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }

            //}

            #endregion
            #region V2
            //Using Linq to sort animal list (requires another list to sort it into.
            //sorting order. Carnivore first, then ordered on size.
            List<Animal> AnimalList = _allAnimals.OrderByDescending(o => o.Type).ThenByDescending(o => o.Size).ToList();

            foreach(Animal animal in AnimalList)
            {
                if(animal.Type == AnimalType.Carnivore)
                {
                    Cart newCart = new Cart();
                    newCart.TryAddAnimal(animal);
                    _cartList.Add(newCart);
                }
                else
                {
                    bool NewCartRequired = true;
                    foreach (Cart cart in _cartList)
                    {
                        if (cart.DoesAnimalFit(animal))
                        {
                            NewCartRequired = false;
                            cart.TryAddAnimal(animal);
                            break;
                        }
                    }
                    if (NewCartRequired == true)
                    {
                        Cart newCart = new Cart();
                        newCart.TryAddAnimal(animal);
                        _cartList.Add(newCart);
                    }
                }
            }
            #endregion

        }

        public void AddAnimal(Animal animal)
        {
            _allAnimals.Add(animal);
        }

        public void Reset()
        {
            _cartList.Clear();
            _allAnimals.Clear();
        }
    }
}
