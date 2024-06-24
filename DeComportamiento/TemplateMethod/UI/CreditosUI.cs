using Core.patrones;
using System;
using System.Collections.Generic;

namespace patrones.TemplateMethod
{
	public class CreditosUI : BaseUI
	{
		private readonly List<string> _creditos;
		private readonly SelectList _selectList;
		private readonly Cliente _cliente;

		public CreditosUI(Cliente cliente)
		{
			_cliente = cliente;
			_creditos = new List<string>
		{
		"Personal",
		"Hipotecario"
		};
			_selectList = new SelectList();
			_selectList.AddRange(_creditos);
			this.Add(_selectList);
		}

		protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
		{
			if (keyInfo.Key == ConsoleKey.UpArrow) _selectList.Previous();
			if (keyInfo.Key == ConsoleKey.DownArrow) _selectList.Next();
			if (keyInfo.Key == ConsoleKey.S) Solicitar();
		}

		public void Solicitar()
		{
			var credito = _creditos[_selectList.GetSelectedIndex() - 1];

			if (credito == null) throw new Exception("debe solucinar un");

			Credito c;

			switch (credito)
			{
				case "Hipotecario":
					c = new CreditoHipotecario(_cliente);
					break;
				case "Personal":
					c = new CreditoPersonal(_cliente);
					break;
				default:
					throw new Exception("Debe seleccinar un credito");
			}
			Console.Write("\nVerificadines:\n" + string.Join('\n', c.Verificar()));
		}

		protected override string AddTextToTemplate() => @"
Presione S para solicitar";
	}
}
