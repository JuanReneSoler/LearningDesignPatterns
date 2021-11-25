using System;
using System.Linq;

namespace patrones.Mediator
{
    public class UserUI
    {
	Usuario _user;
	Usuario _chatWith;
	Chat _chat;
	bool _isRun;

	public UserUI(Chat chat)
	{
	    _chat = chat;
	}

	public void Load(Usuario usuario, Usuario chatWith)
	{
	    _user = usuario;
	    _chatWith = chatWith;
	    _isRun = true;
	    Console.Clear();
	    do
	    {
		Render();
		if(Console.KeyAvailable)
		{
		    var keyPress = Console.ReadKey(true);

		    if(keyPress.Key == ConsoleKey.Q) Exit();

		    if(keyPress.Key == ConsoleKey.V) ViewMessages();

		    if(keyPress.Key == ConsoleKey.S) Send();
		}
	    }
	    while(_isRun);
	}

	void Exit()
	{
	    _isRun = false;
	    Console.Clear();
	}
	
	void Render()
	{
	    Console.SetCursorPosition(0, 0);
	    Console.Write($@"
{_user}

Press S to Send Message
Press V to View Messages
Press Q to Exit
");
	}

	void ViewMessages() => Console.WriteLine(string.Join('\n', _user.Mensajes.AsEnumerable()));

	void Send()
	{
	    Console.Write("Ingese Mensaje: ");
	    var message = Console.ReadLine();
	    _chat.Enviar(message, _chatWith, _user);
	    Console.Clear();
	}
    }
}
