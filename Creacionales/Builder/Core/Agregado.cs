namespace patrones.Builder
{
	public abstract class Agregado
	{
		protected string _descripcion;
		public string Descripcion
		{
			get => _descripcion;
		}
	}

	public class Anchoas : Agregado
	{
		public Anchoas()
		{
			_descripcion = "Anchoas";
		}
	}

	public class Oregano : Agregado
	{
		public Oregano()
		{
			_descripcion = "Oregano";
		}
	}

	public class Berengenas : Agregado
	{
		public Berengenas()
		{
			_descripcion = "Berenjenas";
		}
	}
}
