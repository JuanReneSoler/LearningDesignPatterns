namespace patrones.Command
{
	public abstract class OrderCommand
	{
		public abstract void Ejecutar();
		protected ProductoReceiver _producto;
		protected double _cantidad;

		public OrderCommand(ProductoReceiver producto, double cantidad)
		{
			_producto = producto;
			_cantidad = cantidad;
		}
	}
}
