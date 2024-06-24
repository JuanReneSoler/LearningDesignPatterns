namespace patrones.Builder
{
	public abstract class Masa
	{
		protected string _descripcion;
		public string Descripcion
		{
			get => _descripcion;
		}
	}

	public class AlMolde : Masa
	{
		public AlMolde()
		{
			_descripcion = "Al Molde";
		}
	}

	public class AlaPiedra : Masa
	{
		public AlaPiedra()
		{
			_descripcion = "A la Piedra";
		}
	}

	public class Integral : Masa
	{
		public Integral()
		{
			_descripcion = "Ingral";
		}
	}
}
