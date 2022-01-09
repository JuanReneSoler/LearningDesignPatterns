
namespace patrones.Strategy
{
    public abstract class Arma
    {
	public override string ToString() => this.GetType().Name;
	public abstract string Disparar();
    }
}
