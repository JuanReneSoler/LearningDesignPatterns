using System;

namespace patrones.Singleton
{
	public class SesionManager
	{
		private static SesionManager _sesion;

		public Usuario Usuario;
		public DateTime FechaInicio { get; set; }

		public static SesionManager Instance
		{
			get
			{
				if (_sesion == null) throw new Exception("La sesion no se ha iniciado.");
				return _sesion;
			}
		}

		public static void Login(Usuario usuario)
		{
			if (_sesion == null)
			{
				_sesion = new SesionManager();
				_sesion.Usuario = usuario;
				_sesion.FechaInicio = DateTime.Now;
			}
			else
				throw new Exception("La sesion ya esta iniciada.");
		}

		public static void Logout()
		{
			if (_sesion != null)
				_sesion = null;
			else
				throw new Exception("La sesion no se ha inicado.");
		}

		private SesionManager()
		{
		}
	}
}
