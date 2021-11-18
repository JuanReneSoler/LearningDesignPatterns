

namespace patrones.Builder
{
    public class PizzaLightBuilder : PizzaBuilder
    {
	public PizzaLightBuilder()
	{
	    _descripcion = "Pizza Light";
	}

	public override Masa BuildMasa() => new Integral();
	public override Salsa BuildSalsa() => new Light();
	public override Agregado BuildAgregado() => new Berengenas();
    }
}



