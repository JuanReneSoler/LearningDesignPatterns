using System;

namespace patrones.FactoryMethod
{
	public class Start
	{
		public static void RunPatron()
		{
			var pizzeria = new PizzeriaArgentina();
			var pizza = pizzeria.CreatePizza<PizzaDeCancha>();
			Console.WriteLine(pizza);
		}
	}
}
