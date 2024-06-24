

namespace patrones.Decorator
{
    public class Edulcorante : AgregadoDecorator
    {
	public Edulcorante(BebidaComponent bebida) : base(bebida){}

	public override double Costo => _bebida.Costo+1;
	public override string Description => $"{_bebida.Description}, Edulcorante";
    }
}


