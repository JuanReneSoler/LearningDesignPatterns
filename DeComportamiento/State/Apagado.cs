
namespace patrones.State
{
    public class Apagado : Estado
    {
	public override void ControlarEstado(Switch sw) => sw.DefinirEstado(new Encendido());
	public override string Describir() => "Switch apagado";
    }
}
