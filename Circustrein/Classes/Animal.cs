namespace Classes
{
    public class Animal
    {
        public AnimalSize Size { get; private set; }

        public AnimalType Type { get; private set; }

        public Animal(AnimalSize size, AnimalType type)
        {
            Size = size;
            Type = type;
        }

        public override string ToString()
        {
            return "Animal Info, Size: " + Size + ", Type: " + Type;
        }
    }
}