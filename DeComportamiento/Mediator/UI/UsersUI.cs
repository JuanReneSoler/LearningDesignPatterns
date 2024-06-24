using System;
using System.Linq;
using Core.patrones;

namespace patrones.Mediator
{
    public class UserUI : BaseUI
    {
	Usuario _user;
	Usuario _chatWith;
	Chat _chat;
	Label _lbl;

	public UserUI(Chat chat)
	{
	    _chat = chat;
	    _lbl = new Label();
	}

	public BaseUI SetConversation(Usuario usuario, Usuario chatWith)
	{
	    _user = usuario;
	    _lbl.Title = _user.ToString();
	    _chatWith = chatWith;
	    return this;
	}

	protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
	{
	    if(keyInfo.Key == ConsoleKey.V) ViewMessages();
	    if(keyInfo.Key == ConsoleKey.S) Send();
	}

	protected override string AddTextToTemplate() => $@"
Press S to Send Message
Press V to View Messages";

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
