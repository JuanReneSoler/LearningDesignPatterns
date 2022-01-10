
namespace patrones.Visitor.Ejemplo2
{
    public abstract class Producto : IVisitable
    {
	public double Precio { get; set; }
	public abstract double Aceptar(IVisitor v);
    }
}
