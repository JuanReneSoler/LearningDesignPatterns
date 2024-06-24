using System;

namespace patrones.Strategy
{
	public class Jugador
	{
		Arma _strategia;

		public void CambiarEstrategia(Arma estrategia)
		{
			if (estrategia == null) throw new Exception("la estrategia de disparo no esta disponible");
			_strategia = estrategia;
		}

		public string Nombre { get; set; }

		public string Disparar()
		{
			if (_strategia == null) return "Arma no disponible";
			return _strategia.Disparar();
		}
	}
}
