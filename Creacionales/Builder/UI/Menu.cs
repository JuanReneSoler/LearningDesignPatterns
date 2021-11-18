using System;
using System.Collections.Generic;
using patrones.Builder;

namespace patrones.Builder
{
    public class Menu
    {
	private IList<PizzaBuilder> _lineas;

	private int _position;

	private int Position
	{
	    set
	    {
		if(value < 1)
		    _position = 1;
		else if(value > _lineas.Count)
		    _position = _lineas.Count;
		else
		    _position = value;
	    }

	    get
	    {
	    	if(_position == 0)
		    _position = 1;
		return _position;
	    }
	}

	public Menu()
	{
	    _lineas = new List<PizzaBuilder>();
	    _lineas.Add(new PizzaItalianaBuilder());
	    _lineas.Add(new PizzaMuzzarelaBuilder());
	    _lineas.Add(new PizzaLightBuilder());
	}

	public void Run()
	{
	    Func<int, string> func = (i) => Position == i ? "=>" : "  ";
	    Console.Clear();
	    while(true)
	    {
		Console.SetCursorPosition(0, 0);
		var str = string.Empty;
		var c = 1;
		foreach(var item in _lineas)
		{
		    str += $"\n {func(c++)} {item}";
		}
		Console.Write(str);
		if(Console.KeyAvailable)
		{
		    var keypress = Console.ReadKey(true);
		    if(keypress.Key == ConsoleKey.UpArrow)
			Position--;
		    if(keypress.Key == ConsoleKey.DownArrow)
			Position++;

		    if(keypress.Key == ConsoleKey.Enter)
		    {
			var ubication = Position - 1;
		    	var builder = _lineas[ubication];
			var pizza = builder.BuildPizza();
			Console.WriteLine("\n"+pizza);
			Console.ReadKey();
		    }

		    if(keypress.Key == ConsoleKey.Q)
			break;
		}
	    }
	}
    }
}


