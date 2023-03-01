namespace DecoratorPattern.Models
{
    public abstract class Dish
    {
        public float Preis { get; set; }
        public Dish(float preis)
        {
            Preis = preis;
        }
        public abstract float GetPrice();
        public abstract string GetName();
    }
}