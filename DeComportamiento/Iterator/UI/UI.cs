using System;
using Core.patrones;

namespace patrones.Iterator.Ejemplo1
{
	public class UI : BaseUI
	{
		Collection _collection = new ConcreteCollection();
		IteratorEjemplo _iterator;
		readonly Label _lbl;
		Item primero = default(Item);
		Item actual = default(Item);
		string lista = string.Empty;

		public UI()
		{
			_iterator = _collection.CreateIterator();
			_lbl = new Label();
			_lbl.Title = $@"
			
Lista de elementos creados:
{lista}

Primer Elemento: <<{primero}>>
Elemento Actual <<{actual}>>

presione a para agregar nuevo
presione f para ver el primero
presione n para ver el siguiente
presiones q para salir";
			this.Add(_lbl);
		}

		protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
		{
			if (keyInfo.Key == ConsoleKey.A) Add(out lista);
			if (keyInfo.Key == ConsoleKey.F) GetFirst(out primero, out actual);
			if (keyInfo.Key == ConsoleKey.N) GetNext(out actual);
		}

		private void Add(out string lista)
		{
			Console.Write("Ingre ele nombre del nuevo elemento: ");
			var txt = Console.ReadLine();
			var item = new Item(txt);
			_collection.Agregar(item);
			Listar(out lista);
			Console.Clear();
		}

		private void Listar(out string lista)
		{
			lista = string.Empty;
			if (_collection.Count() > 0)
			{
				_iterator.First();
				lista += $"{_iterator.CurrentItem()}\n";

				while (!_iterator.IsDone())
				{
					_iterator.Siguiente();
					lista += $"{_iterator.CurrentItem()}\n";
				}
			}
		}

		private void GetFirst(out Item primero, out Item actual)
		{
			primero = default(Item);
			actual = default(Item);
			if (_collection.Count() > 0)
			{
				_iterator.First();
				primero = _iterator.CurrentItem();
				actual = primero;
			}
			Console.Clear();
		}

		private void GetNext(out Item actual)
		{
			actual = _iterator.CurrentItem();
			if (!_iterator.IsDone())
			{
				_iterator.Siguiente();
				actual = _iterator.CurrentItem();
			}
		}
	}
}
