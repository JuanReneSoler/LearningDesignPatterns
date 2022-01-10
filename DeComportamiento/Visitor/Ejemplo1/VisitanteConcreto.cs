using System;

namespace patrones.Visitor.Ejemplo1
{
    public class VisitanteConcreto : IVisitor
    {
	/*public void Visitar(Procesador componente) 
	    => Console.WriteLine($"Procesador s/n {componente.Serial}");

	public void Visitar(PlacaBase componente)
	    => Console.WriteLine($"Placa Base s/n {componente.Serial}");

	public void Visitar(DiscoRigido componente) 
	    => Console.WriteLine($"Disco Rigido: s/n {componente.Serial }");
	    */

	public void Visitar(string serial) => Console.WriteLine($"s/n {serial}");
    }

    public class VisitanteConcreto2 : IVisitor
    {
	public void Visitar(string serial) 
	    => Console.WriteLine($"El numero de serie es: {serial}");
    }
}
