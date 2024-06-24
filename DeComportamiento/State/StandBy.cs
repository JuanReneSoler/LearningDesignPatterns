namespace patrones.State
{
    public class StandBy : Estado
    {
        public override void ControlarEstado(Switch sw) => sw.DefinirEstado(new Encendido());
        public override string Describir() => "Switch en stand by";
    }
}
