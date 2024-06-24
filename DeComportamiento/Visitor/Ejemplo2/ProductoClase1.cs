namespace patrones.Visitor.Ejemplo2
{
    public class ProductoClase1 : Producto
    {
        public override double Aceptar(IVisitor v) => v.Visitar(this);
    }
}
