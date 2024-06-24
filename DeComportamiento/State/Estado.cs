namespace patrones.State
{
    public abstract class Estado
    {
        public abstract void ControlarEstado(Switch sw);
        public abstract string Describir();
    }
}
