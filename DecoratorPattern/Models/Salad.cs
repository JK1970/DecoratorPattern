namespace DecoratorPattern.Models
{
    public class Salad : Garnish
    {
        public Salad(Dish komponente) : base(komponente, 4.00f)
        {

        }
    }
}