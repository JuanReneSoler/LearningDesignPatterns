namespace patrones.Facade
{
	public class FacadeImpresora
	{
		Impresora _impresora;

		public FacadeImpresora(string text)
		{
			_impresora = new Impresora();
			_impresora.Nombre = "HP";
			_impresora.TipoHoja = "Carta";
			_impresora.Text = text;
		}

		public void Imprimir() => _impresora.ImprimirDocumento();
	}
}
