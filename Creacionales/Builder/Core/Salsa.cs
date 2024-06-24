
namespace patrones.Builder
{
    public abstract class Salsa
    {
    	protected string _descripcion;
	public string Descripcion
	{
	    get => _descripcion;
	}
    }

    public class Tomate : Salsa
    {
	public Tomate()
	{
	    _descripcion = "Tomate";
	}
    }

    public class Oliva : Salsa
    {
	public Oliva()
	{
	    _descripcion = "Oliva";
	}
    }

    public class Light : Salsa
    {
	public Light()
	{
	    _descripcion = "Light";
	}
    } 
}



