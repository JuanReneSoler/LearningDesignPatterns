using System;

namespace patrones.Mediator
{
	public class Mensaje
	{
		private DateTime _fecha;

		public Mensaje()
		{
			_fecha = DateTime.Now;
		}

		public Usuario De { get; set; }
		public Usuario Para { get; set; }
		public string Texto { get; set; }

		public DateTime Fecha { get => _fecha; }

		public override string ToString() => $"Mensaje a las {Fecha.ToShortTimeString()} de {De} para {Para} --> {Texto}";
	}
}
