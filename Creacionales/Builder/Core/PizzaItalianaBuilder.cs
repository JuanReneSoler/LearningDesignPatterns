
namespace patrones.Builder
{
    public class PizzaItalianaBuilder : PizzaBuilder
    {
	public PizzaItalianaBuilder()
	{
	    _descripcion = "Pizza Italiana";
	}
	public override Masa BuildMasa() => new AlaPiedra();
	public override Salsa BuildSalsa() => new Oliva();
	public override Agregado BuildAgregado() => new Anchoas();
    }
}


