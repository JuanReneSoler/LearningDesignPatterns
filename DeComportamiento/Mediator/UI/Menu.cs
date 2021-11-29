using System;
using System.Linq;

namespace patrones.Mediator
{
    public class Menu
    {
	Chat _chat;
	Usuario _usuario1;
	Usuario _usuario2;
	bool _isRun;
	int _cursorPosition;
	UserUI _userUi;

	private int CursorPosition
	{
	    get => _cursorPosition;

	    set
	    {
		var val = value;
		if(val < 1) val = 1;
		if(val > 3) val = 3;

		_cursorPosition = val;
	    }
	}

	public Menu()
	{
	    _chat = new Chatroom();
	    _usuario1 = new Usuario1("Usuario 1");
	    _usuario2 = new Usuario2("Usuario 2");

	    _isRun = true;
	    _cursorPosition = 1;
	    _userUi = new UserUI(_chat);

	    _chat.Registrar(_usuario1);
	    _chat.Registrar(_usuario2);

	    Console.CursorVisible = false;
	    Console.Clear();
	}

	public void Load()
	{
	    do
	    {
		Render();
		if(Console.KeyAvailable)
		{
		    var keyPress = Console.ReadKey(true);

		    if(keyPress.Key == ConsoleKey.Q) Exit();

		    if(keyPress.Key == ConsoleKey.UpArrow) UpCursor();

		    if(keyPress.Key == ConsoleKey.DownArrow) DownCursor();

		    if(keyPress.Key == ConsoleKey.Enter) PressEnter();
		}
	    }
	    while(_isRun);
	}

	void Exit()
	{
	    Console.Clear();
	    Console.CursorVisible = true;
	    _isRun = false;
	}

	void Render()
	{
	    Console.SetCursorPosition(0, 0);
	    Console.Write($@"

{RenderCursor(1)} {_usuario1}({_usuario1.Mensajes.Count()})
{RenderCursor(2)} {_usuario2}({_usuario2.Mensajes.Count()})
{RenderCursor(3)} Ver todos los mensajes ({_chat.Mensajes.Count()})

Press Q to Exit");
	}

	string RenderCursor(int position) => position == CursorPosition ? "=>" : "  ";
	void UpCursor() => CursorPosition--;
	void DownCursor() => CursorPosition++;

	void PressEnter()
	{
	    if(CursorPosition == 1)
		_userUi.Load(_usuario1, _usuario2);

	    if(CursorPosition == 2)
		_userUi.Load(_usuario2, _usuario1);

	    if(CursorPosition == 3)
		Console.WriteLine($@"

Mensajes:

{string.Join('\n', _chat.Mensajes.AsEnumerable())}");
	}
    }
}

