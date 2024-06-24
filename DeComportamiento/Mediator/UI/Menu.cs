using System;
using System.Linq;
using Core.patrones;

namespace patrones.Mediator
{
    public class Menu : BaseUI
    {
	Chat _chat;
	Usuario _usuario1;
	Usuario _usuario2;
	UserUI _userUi;
	SelectList _selectList;

	public Menu()
	{
	    _chat = new Chatroom();
	    _usuario1 = new Usuario1("Usuario 1");
	    _usuario2 = new Usuario2("Usuario 2");

	    _userUi = new UserUI(_chat);

	    _chat.Registrar(_usuario1);
	    _chat.Registrar(_usuario2);

	    _selectList = new SelectList();
	    _selectList.Add(_usuario1);
	    _selectList.Add(_usuario2);
	    _selectList.Add($"Ver todos los mensages ({_chat.Mensajes.Count()})");
	    this.Add(_selectList);
	}

	protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
	{
	    if(keyInfo.Key == ConsoleKey.UpArrow) _selectList.Previous();
	    if(keyInfo.Key == ConsoleKey.DownArrow) _selectList.Next();
	    if(keyInfo.Key == ConsoleKey.Enter) PressEnter();
	}

	void PressEnter()
	{
	    if(_selectList.GetSelectedIndex() == 1)
		_userUi.SetConversation(_usuario1, _usuario2).Load();

	    if(_selectList.GetSelectedIndex() == 2)
		_userUi.SetConversation(_usuario2, _usuario1).Load();

	    if(_selectList.GetSelectedIndex() == 3)
		Console.WriteLine($@"

Mensajes:

{string.Join('\n', _chat.Mensajes.AsEnumerable())}");
	}
    }
}

