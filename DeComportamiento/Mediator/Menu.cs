using System;

namespace patrones.Mediator
{
    public class Menu
    {
	Chat _chat;
	Usuario _usuario1;
	Usuario _usuario2;
	bool _isRun;

	public Menu()
	{
	    _chat = new Chatroom();
	    _usuario1 = new Usuario1("Usuario 1");
	    _usuario2 = new Usuario2("Usuario 2");

	    _isRun = true;

	    _chat.Registrar(_usuario1);
	    _chat.Registrar(_usuario2);

	    Console.CursorVisible = false;
	    Console.Clear();
	}

	public void Load()
	{
	    Console.WriteLine("prueba");
	    do
	    {
		if(Console.KeyAvailable)
		{
		    var keyPress = Console.ReadKey(true);

		    if(keyPress.Key == ConsoleKey.Q) Exit();
		}
	    }
	    while(_isRun);
	}

	void Exit()
	{
	    Console.CursorVisible = true;
	    _isRun = false;
	}
    }
}

