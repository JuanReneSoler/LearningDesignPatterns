using System;

namespace patrones.Iterator
{
    public class UI
    {
	private Collection _collection = new ConcreteCollection();
	private IteratorEjemplo _iterator;
	private bool isRun;

	public UI()
	{
	    _iterator = _collection.CreateIterator();
	    isRun = true;
	}

	public void Run()
	{
	    Console.CursorVisible = false;
	    Item primero = default(Item);
	    Item actual = default(Item);
	    string lista = string.Empty;
	    do
	    {
		Console.SetCursorPosition(0, 0);
		Console.WriteLine($@"
			
Lista de elementos creados:
{lista}

Primer Elemento: <<{primero}>>
Elemento Actual <<{actual}>>

presione a para agregar nuevo
presione f para ver el primero
presione n para ver el siguiente
presiones q para salir

");
		if(Console.KeyAvailable)
		{
		    var keyPress = Console.ReadKey(true);

		    if(keyPress.Key == ConsoleKey.Q) Quit();

		    if(keyPress.Key == ConsoleKey.A) Add(out lista);

		    if(keyPress.Key == ConsoleKey.F) GetFirst(out primero, out actual);

		    if(keyPress.Key == ConsoleKey.N) GetNext(out actual);
		}
	    }while(isRun);
	    Console.CursorVisible = true;
	}

	private void Quit() => isRun = false;

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
	    if(_collection.Count() > 0)
	    {
		_iterator.First();
		lista += $"{_iterator.CurrentItem()}\n";

		while(!_iterator.IsDone())
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
	    if(_collection.Count() > 0)
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
	    if(!_iterator.IsDone())
	    {
		_iterator.Siguiente();
		actual = _iterator.CurrentItem();
	    }
	}
    }
}
