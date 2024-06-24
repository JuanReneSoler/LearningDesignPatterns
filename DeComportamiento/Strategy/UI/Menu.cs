using System;
using Core.patrones;
using System.Collections.Generic;

namespace patrones.Strategy
{
	public class Menu : BaseUI
	{
		private readonly SelectList _selectList;
		private readonly List<Arma> _estrategiasDisparo;
		private readonly Jugador _jugador;

		public Menu()
		{
			_selectList = new SelectList();
			_estrategiasDisparo = new List<Arma>
		{
		new Pistola(),
		new Bazooka(),
		new Ak47(),
		new AireComprimido()
		};
			_selectList.AddRange(_estrategiasDisparo);
			this.Add(_selectList);
			_jugador = new Jugador();
			_jugador.Nombre = "Rambo";
			_selectList.Title = _jugador.Nombre;
		}

		protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
		{
			if (keyInfo.Key == ConsoleKey.UpArrow) _selectList.Previous();
			if (keyInfo.Key == ConsoleKey.DownArrow) _selectList.Next();
			if (keyInfo.Key == ConsoleKey.D) Console.Write($"\n\n{_jugador.Disparar()}");
			if (keyInfo.Key == ConsoleKey.Enter)
				_jugador.CambiarEstrategia(_estrategiasDisparo[_selectList.GetSelectedIndex() - 1]);
		}

		protected override string AddTextToTemplate()
			=> @"
Presiona Enter para seleccionar
Presiona D para disparar";
	}
}
