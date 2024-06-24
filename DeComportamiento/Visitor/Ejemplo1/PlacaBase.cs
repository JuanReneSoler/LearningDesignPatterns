namespace patrones.Visitor.Ejemplo1
{
    public class PlacaBase : Componente
    {
        public PlacaBase(string serial) : base(serial) { }

        //public override void Aceptar(IVisitor visitor) => visitor.Visitar(this);
    }
}
