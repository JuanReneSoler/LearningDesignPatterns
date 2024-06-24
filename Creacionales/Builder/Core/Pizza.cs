namespace patrones.Builder
{
	public class Pizza
	{
		private Masa _masa;
		private Salsa _salsa;
		private Agregado _agregado;
		private string _descripcion;

		public override string ToString() =>
			$@"Masa: {_masa.Descripcion}, Salsa :{_salsa.Descripcion}, Agregado: {_agregado.Descripcion}, Tipo: {_descripcion}";

		public Pizza(Masa masa, Salsa salsa, Agregado agregado, string descripcion)
		{
			_masa = masa;
			_salsa = salsa;
			_agregado = agregado;
			_descripcion = descripcion;
		}
	}
}
