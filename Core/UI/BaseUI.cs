using System;
using System.Collections.Generic;

namespace Core.patrones
{
    public abstract class BaseUI
    {
	private bool _isRun;
	private List<BaseComponent> _components;

	public BaseUI()
	{
	    _isRun = true;
	    Console.CursorVisible = false;
	    _components = new List<BaseComponent>();
	    Console.Clear();
	}

	public void Add(BaseComponent component)
	{
	    if(!_components.Contains(component))
		_components.Add(component);
	}
	public void Remove(BaseComponent component)
	{
	    if(_components.Contains(component))
		_components.Remove(component);
	}

	public void Load()
	{
	    Console.Clear();
	    do
	    {
		Render();
		if(Console.KeyAvailable)
		{
		    var keyInfo = Console.ReadKey(true);
		    if(keyInfo.Key == ConsoleKey.Q) Quit();
		    OnKeyPress(keyInfo);
		}
	    }while(_isRun);
	}

	protected virtual void OnKeyPress(ConsoleKeyInfo keyInfo){}

	public void Quit()
	{
	    _isRun = false;
	    Console.CursorVisible = true;
	    Console.Clear();
	}

	private void Render()
	{
	    Console.SetCursorPosition(0, 0);
	    if(_components.Count > 0)
		Console.Write(string.Join('\n', _components));
	    Console.Write("Press Q to quit");
	    Console.Write(AddTextToTemplate());
	}

	protected virtual string AddTextToTemplate() => string.Empty;
    }
}
