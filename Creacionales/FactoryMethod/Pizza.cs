

namespace patrones.FactoryMethod
{
    public abstract class Pizza
    {
	private string _origen;
	protected string _descripcion;
    	public Pizza(string origen)
	{
	    _origen = origen;
	}

	public override string ToString() => $"{_descripcion} hecha en: {_origen}";
    }
}



