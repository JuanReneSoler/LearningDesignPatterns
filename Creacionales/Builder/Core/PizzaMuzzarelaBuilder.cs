

namespace patrones.Builder
{
    public class PizzaMuzzarelaBuilder : PizzaBuilder
    {
	public PizzaMuzzarelaBuilder()
	{
	    _descripcion = "Pizza Muzzarela";
	}

	public override Masa BuildMasa() => new AlMolde();
	public override Salsa BuildSalsa() => new Tomate();
	public override Agregado BuildAgregado() => new Oregano();
    }
}


