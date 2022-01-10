//using patrones.Visitor.Ejemplo1;
using patrones.Visitor.Ejemplo2;
using System;

namespace patrones.Visitor
{
    public class Start
    {
	/*private static void Ejemplo1()
	{
	    IVisitor visitante = new VisitanteConcreto();
	    IVisitor visitante2 = new VisitanteConcreto2();

	    Componente dr = new DiscoRigido("1231DSFFSD3-DR");
	    Componente pb = new PlacaBase("dkk3nndj12313-PB");
	    Componente p = new Procesador("9393SKKK4K3k-P");

	    dr.Aceptar(visitante);
	    pb.Aceptar(visitante2);
	    p.Aceptar(visitante);
	}*/

	private static void Ejemplo2()
	{
	    var pc1 = new ProductoClase1();
	    pc1.Precio = 100;
	    var pc2 = new ProductoClase2();
	    pc2.Precio = 100;
	    
	    //var iva = new IVA();
	    var iva = new OtroImpuesto();
	    Console.WriteLine($"El total para el producto clase 1 es: {pc1.Aceptar(iva)}");
	    Console.WriteLine($"El total para el producto clase 2 es: {pc2.Aceptar(iva)}");
	}

	public static void RunPatron()
	{
	    //Ejemplo1();
	    Ejemplo2();
	}
    }
}
