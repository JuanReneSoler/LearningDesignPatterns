


namespace patrones.Decorator
{
    public class Leche : AgregadoDecorator
    {
	public Leche(BebidaComponent bebida) : base(bebida){}
	public override double Costo => _bebida.Costo + 2;
	public override string Description => $"{_bebida.Description}, Leche";
    }
}




