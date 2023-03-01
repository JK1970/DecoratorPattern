namespace DecoratorPattern.Models
{
    public class Potatoes : Garnish
    {
        public Potatoes(Dish komponente) : base(komponente, 2.00f)
        {

        }
    }
}