namespace patrones.Visitor.Ejemplo2
{
    public class IVA : IVisitor
    {
        private double impuestoClase1 = 1.21d;
        private double impuestoClase2 = 1.105d;

        public double Visitar(ProductoClase2 p) => p.Precio * impuestoClase2;

        public double Visitar(ProductoClase1 p) => p.Precio * impuestoClase1;
    }

    public class OtroImpuesto : IVisitor
    {
        public double Visitar(ProductoClase1 p) => p.Precio * 1.4;
        public double Visitar(ProductoClase2 p) => p.Precio * 0.8;
    }
}
