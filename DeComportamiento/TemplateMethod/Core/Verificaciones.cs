using System.Collections.Generic;

namespace patrones.TemplateMethod
{
	public abstract class Verificaciones
	{
		protected Cliente _cliente;

		public string[] Verificar()
			 => new List<string>
			{
		$"Verificando credito para {_cliente.Nombre}",
		VerificarAcciones(),
		VerificarBalance(),
		VerificarCredito(),
		VerificarIngresos()
			}.ToArray();

		protected abstract string VerificarAcciones();
		protected abstract string VerificarBalance();
		protected abstract string VerificarCredito();
		protected abstract string VerificarIngresos();
	}
}
