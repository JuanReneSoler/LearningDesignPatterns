using System;

namespace patrones.ChainOfResponsability
{
    public class Start
    {
	public static void RunPatron()
	{
	    var comprador = new Comprador();
	    var gerente = new Gerente();
	    var director = new Director();
	    var directorGeneral = new DirectorGeneral();
	    comprador.AgregarSiguiente(gerente);
	    gerente.AgregarSiguiente(director);
	    director.AgregarSiguiente(directorGeneral);

	    var compra = new Compra();
	    var importe = 1.1;
	    while(importe != 0)
	    {
		Console.WriteLine("Ingrese el importe de la compra: (0 para terminar)");
		importe = double.Parse(Console.ReadLine());
		compra.Importe = importe;
		comprador.Procesar(compra);
	    }
	}
    }
}
