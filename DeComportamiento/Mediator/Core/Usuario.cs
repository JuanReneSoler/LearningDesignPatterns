using System.Collections.Generic;

namespace patrones.Mediator
{
	public abstract class Usuario
	{
		List<Mensaje> _mensajes;
		string _nombre;

		public Usuario(string nombre)
		{
			_nombre = nombre;
			_mensajes = new List<Mensaje>();
		}

		public Mensaje[] Mensajes
		{
			get => _mensajes.ToArray();
		}

		public string Nombre
		{
			get => _nombre;
		}

		public override string ToString() => $"{_nombre} {_mensajes.Count}";
		public Chat Chat { get; set; }
		public void Enviar(string _mensaje, Usuario para) => Chat.Enviar(_mensaje, para, this);
		public void Recibir(Mensaje mensaje) => _mensajes.Add(mensaje);
	}
}
