using System;

namespace patrones.ChainOfResponsability
{
    public class DirectorGeneral : Aprobador
    {
	public override void Procesar(Compra compra)
	    => Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");
    }
}


