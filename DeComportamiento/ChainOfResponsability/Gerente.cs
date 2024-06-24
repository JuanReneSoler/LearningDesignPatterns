using System;

namespace patrones.ChainOfResponsability
{
	public class Gerente : Aprobador
	{
		public override void Procesar(Compra compra)
		{
			if (compra.Importe <= 1000)
				Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");
			else
				_siguiente.Procesar(compra);
		}
	}
}
