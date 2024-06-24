using System;

namespace patrones.Bridge
{
	public class Rectangulo : Figura
	{
		public Rectangulo(Color color) : base(color)
		{ }

		public override void Dibujar()
		{
			Console.WriteLine("Dibujando Restangulo!");
			_color.Pintar();
		}
	}
}
