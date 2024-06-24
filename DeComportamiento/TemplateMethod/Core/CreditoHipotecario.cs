
namespace patrones.TemplateMethod
{
	public class CreditoHipotecario : Credito
	{
		public CreditoHipotecario(Cliente cliente) : base(cliente)
		{ }
		protected override string VerificarAcciones() => "Acciones verificadas credito hipotecario";
		protected override string VerificarBalance() => "Valance verificado credito hipotecario";
		protected override string VerificarCredito() => "credito verificado";
		protected override string VerificarIngresos() => "Sin Ingresos";
	}
}
