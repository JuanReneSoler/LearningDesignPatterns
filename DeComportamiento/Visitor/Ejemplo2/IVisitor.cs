
namespace patrones.Visitor.Ejemplo2
{
    public interface IVisitor
    {
	double Visitar(ProductoClase1 p);
	double Visitar(ProductoClase2 p);
    }
}
