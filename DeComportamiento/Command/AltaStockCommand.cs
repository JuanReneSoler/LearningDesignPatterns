

namespace patrones.Command
{
    public class AltaStockCommand : OrderCommand
    {
	public AltaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
	{
	}

	public override void Ejecutar() => _producto.SumarStock(_cantidad);
    }
}

