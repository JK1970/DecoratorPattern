namespace DecoratorPattern.Models
{
    public class FrenchFries : Garnish
    {
        public FrenchFries(Dish komponente) : base(komponente, 1.00f)
        {

        }
    }
}