namespace DecoratorPattern.Models
{
    public class Rice : Garnish
    {
        public Rice(Dish komponente) : base(komponente, 2.00f)
        {

        }
    }
}