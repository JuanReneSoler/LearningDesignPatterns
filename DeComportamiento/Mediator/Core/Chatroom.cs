using System.Collections.Generic;

namespace patrones.Mediator
{
    public class Chatroom : Chat
    {
	IDictionary<string, Usuario> _participantes;

	public Chatroom()
	{
	    _participantes = new Dictionary<string, Usuario>();
	}

	public override void Enviar(string Mensaje, Usuario para, Usuario de)
	{
	    var msg = new Mensaje();
	    msg.De = de;
	    msg.Para = para;
	    msg.Texto = Mensaje;

	    if(_participantes.ContainsKey(para.Nombre))
	    {
		_participantes[para.Nombre].Recibir(msg);
		_mensajes.Add(msg);
	    }
	}
	
	public override void Registrar(Usuario usuario)
	{
	    if(!_participantes.ContainsKey(usuario.Nombre))
		_participantes.Add(usuario.Nombre, usuario);
	}
    }
}
