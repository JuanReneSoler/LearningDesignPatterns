namespace patrones.FactoryMethod
{
    public class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana(string origen) : base(origen)
        {
            _descripcion = "Pizza Napolitana";
        }
    }
}
