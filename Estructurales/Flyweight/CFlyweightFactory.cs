using System;
using System.Collections.Generic;

namespace patrones.Flyweight
{
    public class CFlyweightFactory
    {
	List<IFlyweight> _flyweights = new List<IFlyweight>();
	int _conteo = 0;
	Func<string, bool> _flyweightExit => (_nombre)=>_flyweights.Exists(i => i.ObtenerNombre() == _nombre);

	public int Conteo { get => _conteo; set => _conteo = value; }
	public int Adiciona(string nombre)
	{
	    if(_flyweightExit(nombre))
	    {
		Console.WriteLine("El objeto ya existe, no puede volver a agregarlo.");
		return -1;
	    }
	    else
	    {
		var receta = new CReceta();
		receta.ColocaNombre(nombre);
		_flyweights.Add(receta);
		_conteo = _flyweights.Count;
		return _conteo - 1;
	    }
	}
	public IFlyweight this[int index] => _flyweights[index];
    }
}


