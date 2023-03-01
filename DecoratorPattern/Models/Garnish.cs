namespace DecoratorPattern.Models
{
    public abstract class Garnish : Dish
    {
        public Dish Komponente { get; set; }
        public Garnish(Dish komponente, float preis) : base(preis)
        {
            Komponente = komponente;
        }
        public override float GetPrice()
        {
            return Preis + Komponente.GetPrice();
        }
        public override string GetName()
        {
            return Komponente.GetName() + " with " + GetType().Name.ToString();
        }
    }
}