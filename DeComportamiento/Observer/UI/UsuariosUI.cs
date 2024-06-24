using System;
using Core.patrones;
using System.Collections.Generic;

namespace patrones.Observer
{
	public class UsuariosUI : BaseUI
	{
		private readonly List<IObserverUsuario> _usuarios;
		private readonly SelectList _selectList;
		private readonly ISujetoProducto _producto;

		public UsuariosUI(ISujetoProducto producto)
		{
			_producto = producto;
			_usuarios = new List<IObserverUsuario>
		{
		new Usuario("Juan", "Soler"),
		new Usuario("Aurora", "Soler"),
		new Usuario("Pedro", "Soler")
		};
			_selectList = new SelectList();
			_selectList.AddRange(_usuarios);
			this.Add(_selectList);
		}

		protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
		{
			if (keyInfo.Key == ConsoleKey.UpArrow) _selectList.Previous();
			if (keyInfo.Key == ConsoleKey.DownArrow) _selectList.Next();
			if (keyInfo.Key == ConsoleKey.S) Suscribe();
			if (keyInfo.Key == ConsoleKey.U) Unsuscribe();
		}

		private void Unsuscribe()
		{
			_producto.Quitar(_usuarios[_selectList.GetSelectedIndex() - 1]);
			Quit();
		}
		private void Suscribe()
		{
			_producto.Agregar(_usuarios[_selectList.GetSelectedIndex() - 1]);
			Quit();
		}

		protected override string AddTextToTemplate() => $@"
Press S to Suscribe at product: {_producto}
Press U to unsuscribe at product {_producto}";
	}
}
