using System;

namespace patrones.Facade
{
	public class Impresora
	{
		string _nombre;
		string _tipoHoja;
		string _text;

		public string Nombre
		{
			get => _nombre;
			set => _nombre = value;
		}

		public string TipoHoja
		{
			get => _tipoHoja;
			set => _tipoHoja = value;
		}

		public string Text
		{
			get => _text;
			set => _text = value;
		}

		public void ImprimirDocumento() => Console.WriteLine($"La impresora: {_nombre} esta imprimiendo... \n tipo de hoja: {_tipoHoja} \n {_text}");
	}
}
