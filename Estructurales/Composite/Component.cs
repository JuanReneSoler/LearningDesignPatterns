using System.Collections.Generic;

namespace patrones.Composite
{
	public abstract class Component
	{
		string _nombre;

		public Component(string nombre)
		{
			_nombre = nombre;
		}

		public string Nombre { get => _nombre; }
		public abstract void AgregarHijo(Component coponentChild);
		public abstract IList<Component> ObtenerHijos();
		public abstract int ObtenerTamano { get; }
	}
}
