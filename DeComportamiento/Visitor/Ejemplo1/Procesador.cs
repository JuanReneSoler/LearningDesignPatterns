namespace patrones.Visitor.Ejemplo1
{
    public class Procesador : Componente
    {
        public Procesador(string serial) : base(serial) { }

        //public override void Aceptar(IVisitor visitor) => visitor.Visitar(this);
    }
}
