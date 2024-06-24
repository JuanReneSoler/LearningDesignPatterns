using System;
using System.Collections.Generic;
using Core.patrones;

namespace patrones.Builder
{
    public class Menu : BaseUI
    {
	private IList<PizzaBuilder> _lineas;
	private readonly SelectList _selectList;

	public Menu()
	{
	    _lineas = new List<PizzaBuilder>
	    {
		new PizzaItalianaBuilder(),
		new PizzaMuzzarelaBuilder(),
		new PizzaLightBuilder()
	    };
	    _selectList = new SelectList();
	    _selectList.AddRange(_lineas);
	    this.Add(_selectList);
	}

	protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
	{
	    if(keyInfo.Key == ConsoleKey.UpArrow) _selectList.Previous();
	    if(keyInfo.Key == ConsoleKey.DownArrow) _selectList.Next();
	    if(keyInfo.Key == ConsoleKey.Enter) Build();
	}

	private void Build()
	{
	    var builder = _lineas[_selectList.GetSelectedIndex() - 1];
	    var pizza = builder.BuildPizza();
	    Console.WriteLine("\n"+pizza);
	}
    }
}


