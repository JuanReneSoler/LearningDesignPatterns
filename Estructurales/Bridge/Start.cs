using System;

namespace patrones.Bridge
{
    public class Start
    {
	public static void RunPatron()
	{
	    var figuras = new Figura[2]
	    {
		new Circulo(new Negro()),
		new Rectangulo(new Azul())
	    };

	    foreach(var figura in figuras)
		figura.Dibujar();
	}
    }
}
