using System;

namespace patrones.Facade
{
    public class Start
    {
	public static void RunPatron()
	{
	    var impresora = new FacadeImpresora("Hello World!");
	    impresora.Imprimir();
	}
    }
}
