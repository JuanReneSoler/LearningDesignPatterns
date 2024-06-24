namespace patrones.AbstractFactory
{
	public class PizzeriaItaliana : Pizzeria
	{
		public override Pizza CreatePizza()
		{
			return new PizzaItaliana();
		}

		public override Empanada CreateEmpanada()
		{
			return new EmpanadaDeCarne();
		}
	}
}
