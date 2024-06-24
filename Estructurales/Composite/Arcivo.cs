using System.Collections.Generic;
using System;

namespace patrones.Composite
{
	public class Archivo : Component
	{
		int _tamano;

		public Archivo(string nombre, int tamano) : base(nombre)
		{
			_tamano = tamano;
		}

		public int Tamano { get => _tamano; }

		public override void AgregarHijo(Component coponentChild) => throw new NotImplementedException();

		public override IList<Component> ObtenerHijos() => throw new NotImplementedException();

		public override int ObtenerTamano => _tamano;
	}
}
