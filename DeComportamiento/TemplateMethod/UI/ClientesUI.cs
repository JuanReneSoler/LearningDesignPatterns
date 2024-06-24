using Core.patrones;
using System.Collections.Generic;
using System;

namespace patrones.TemplateMethod
{
	public class ClientesUI : BaseUI
	{
		private readonly List<Cliente> _clientes;
		private readonly SelectList _selectList;

		public ClientesUI()
		{
			_clientes = new List<Cliente>
		{
		new Cliente { Nombre = "Roberto Gomez" },
		new Cliente { Nombre = "Marta Sanchez" }
		};
			_selectList = new SelectList();
			_selectList.AddRange(_clientes);
			this.Add(_selectList);
		}

		protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
		{
			if (keyInfo.Key == ConsoleKey.UpArrow) _selectList.Previous();
			if (keyInfo.Key == ConsoleKey.DownArrow) _selectList.Next();
			if (keyInfo.Key == ConsoleKey.Enter) SelectItem();
		}

		private void SelectItem()
		{
			var client = _clientes[_selectList.GetSelectedIndex() - 1];
			new CreditosUI(client).Load();
		}
	}
}
