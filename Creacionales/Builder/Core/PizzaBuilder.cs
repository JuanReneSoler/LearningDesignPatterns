namespace patrones.Builder
{
	public abstract class PizzaBuilder
	{
		protected string _descripcion;
		public abstract Masa BuildMasa();
		public abstract Salsa BuildSalsa();
		public abstract Agregado BuildAgregado();

		public override string ToString() => _descripcion;

		public Pizza BuildPizza()
		{
			var masa = BuildMasa();
			var salsa = BuildSalsa();
			var agregado = BuildAgregado();
			return new Pizza(masa, salsa, agregado, _descripcion);
		}
	}
}
