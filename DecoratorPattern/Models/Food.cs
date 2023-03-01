namespace DecoratorPattern.Models
{
    public abstract class Food : Dish
    {
        public Food(float preis) : base(preis)
        {

        }
        public override float GetPrice()
        {
            return Preis;
        }
        public override string GetName()
        {
            return GetType().Name.ToString();
        }
    }
}