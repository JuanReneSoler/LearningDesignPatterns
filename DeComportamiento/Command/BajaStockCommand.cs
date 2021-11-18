

namespace patrones.Command
{
    public class BajaStockCommand : OrderCommand
    {
	public BajaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
	{
	}

	public override void Ejecutar() => _producto.RestarStock(_cantidad);
    }
}

