using System;

namespace patrones.Prototype
{
    public class Start
    {
	public static void RunPatron()
	{
	    var prototypeFiat = new FiatPrototype();
	   
	    var fiatPalio = prototypeFiat.Clonar();
	    fiatPalio.Modelo = "Palio Fire";
	    fiatPalio.Color = "Negro";

	    var fiatUno = prototypeFiat.Clonar();
	    fiatUno.Modelo = "Uno SRC";
	    fiatUno.Color = "Blanco";

	    var alfaRomeroPrototype = new AlfaRomeoPrototype();
	    var romeo = alfaRomeroPrototype.Clonar();
	    romeo.Modelo = "Power";
	    romeo.Color = "Blanco";

	    Console.WriteLine(fiatPalio.VerAuto());
	    Console.WriteLine(fiatUno.VerAuto());
	    Console.WriteLine(romeo.VerAuto());
	}
    }
}
