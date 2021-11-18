using System;
using System.Linq;

namespace patrones.Flyweight
{
    public class CReceta : IFlyweight
    {
	string _nombre;
	double _costo;
	double _venta;

	public void ColocaNombre(string nombre) => _nombre = nombre;
	public void CalculaCosto()
	{
	    _costo = _nombre.Sum(letra => (int)letra);
	    _venta = _costo * 1.30;
	}
	public void Mostrar() => Console.WriteLine($"{_nombre} cuesta: {_venta}");
	public string ObtenerNombre() => _nombre;
    }
}

