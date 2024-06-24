
namespace patrones.TemplateMethod
{
	public class CreditoPersonal : Credito
	{
		public CreditoPersonal(Cliente cliente) : base(cliente)
		{ }

		protected override string VerificarAcciones() => "Acciones verificadas credito personal";
		protected override string VerificarBalance() => "Balance verificado credito presonal";
		protected override string VerificarCredito() => "Sin credito";
		protected override string VerificarIngresos() => "Ingreso verificado credito personal";
	}
}
