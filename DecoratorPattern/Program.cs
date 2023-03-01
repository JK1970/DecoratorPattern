using DecoratorPattern.Models;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Dish dish = new FrenchFries(new Salad(new Cutlet()));
            Console.WriteLine("Dish  : {0}", dish.GetName());
            Console.WriteLine("Price : {0}", dish.GetPrice());
        }
    }
}
