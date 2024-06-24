using System.Collections.Generic;

namespace patrones.Mediator
{
	public abstract class Chat
	{
		protected List<Mensaje> _mensajes;

		public Chat()
		{
			_mensajes = new List<Mensaje>();
		}

		public Mensaje[] Mensajes
		{
			get => _mensajes.ToArray();
		}

		public abstract void Enviar(string Mensaje, Usuario para, Usuario de);
		public abstract void Registrar(Usuario usuario);
	}
}
