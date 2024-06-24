namespace patrones.State
{
    public class Encendido : Estado
    {
        public override void ControlarEstado(Switch sw) => sw.DefinirEstado(new Apagado());
        public override string Describir() => "Switch Encendido";
    }
}
