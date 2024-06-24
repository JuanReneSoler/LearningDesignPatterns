using System;

namespace patrones.Bridge
{
    public class Circulo : Figura
    {
	public Circulo(Color color) : base(color)
	{}

	public override void Dibujar()
	{
	    Console.WriteLine("Dibujando Circulo!");
	    _color.Pintar();
	}
    }
}






