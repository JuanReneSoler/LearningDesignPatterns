using System;
using System.Collections.Generic;

namespace patrones.Flyweight
{
	public class Start
	{
		public static void RunPatron()
		{
			var americana = new List<int>();
			var mexicana = new List<int>();

			var ffactory = new CFlyweightFactory();
			var i = ffactory.Adiciona("Hamburgesa");
			americana.Add(i);

			i = ffactory.Adiciona("Taco");
			mexicana.Add(i);

			i = ffactory.Adiciona("Carne a la plancha");
			americana.Add(i);
			mexicana.Add(i);

			Console.WriteLine("Comida Americana");
			foreach (var item in americana)
			{
				var receta = (CReceta)ffactory[item];
				receta.CalculaCosto();
				receta.Mostrar();
			}

			Console.WriteLine("\n");

			Console.WriteLine("Comida Mexicana");
			foreach (var item in mexicana)
			{
				var receta = (CReceta)ffactory[item];
				receta.Mostrar();
			}

			i = ffactory.Adiciona("Hamburgesa");
		}
	}
}
