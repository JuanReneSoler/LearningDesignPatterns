using System.Collections.Generic;
using System.Linq;

namespace patrones.Composite
{
	public class Directorio : Component
	{
		List<Component> _hijos;

		public Directorio(string nombre) : base(nombre)
		{
			_hijos = new List<Component>();
		}

		public override void AgregarHijo(Component coponentChild) => _hijos.Add(coponentChild);
		public override IList<Component> ObtenerHijos() => _hijos.ToArray();
		public override int ObtenerTamano => _hijos.Sum(hijo => hijo.ObtenerTamano);
	}
}
