namespace patrones.Visitor.Ejemplo2
{
    public class ProductoClase2 : Producto
    {
        public override double Aceptar(IVisitor v) => v.Visitar(this);
    }
}
