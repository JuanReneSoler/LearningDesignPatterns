using System;
using System.Collections.Generic;

namespace patrones.Observer
{
	public class Producto : ISujetoProducto
	{
		private List<IObserverUsuario> _usuarios;
		public Producto(string nombre, double precio)
		{
			_usuarios = new List<IObserverUsuario>();
			Nombre = nombre;
			_precio = precio;
		}

		public string Nombre { get; set; }

		double _precio;
		public double Precio
		{
			get => _precio;
			set
			{
				_precio = value;
				this.Notificar();
			}
		}

		public override string ToString() => $"{Nombre} $({_precio})";

		public void Agregar(IObserverUsuario usuario)
		{
			if (!_usuarios.Contains(usuario))
				_usuarios.Add(usuario);
			else throw new Exception($"Ya existe una suscripcion a {(Usuario)usuario}");
		}

		public void Notificar()
		{
			foreach (var usuario in _usuarios)
				usuario.Actualizar(this);

			if (_usuarios.Count == 0)
				ProductosUI.Notificar("No hay suscripciones");

			ProductosUI.Notificar("_____________________________________");
		}

		public void Quitar(IObserverUsuario usuario)
		{
			if (_usuarios.Contains(usuario))
				_usuarios.Remove(usuario);
			else throw new Exception($"No existe una suscripcion para {(Usuario)usuario}");
		}
	}
}
