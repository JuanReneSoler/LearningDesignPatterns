using System;

namespace patrones.ChainOfResponsability
{
    public class Comprador : Aprobador
    {
	public override void Procesar(Compra compra)
	{
	    if(compra.Importe < 100)
		Console.WriteLine($"Compra aprobada por {this.GetType().Name}");
	    else
		_siguiente.Procesar(compra);
	}
    }
}


