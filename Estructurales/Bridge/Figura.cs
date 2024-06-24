
namespace patrones.Bridge
{
    public abstract class Figura
    {
	protected Color _color;
	
	public Figura(Color color)
	{
	    _color = color;
	}

	public abstract void Dibujar();
    }
}


