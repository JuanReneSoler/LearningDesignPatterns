namespace patrones.FactoryMethod
{
    public class PizzaDeCancha : Pizza
    {
        public PizzaDeCancha(string origen) : base(origen)
        {
            _descripcion = "Pizza de Cancha";
        }
    }
}
