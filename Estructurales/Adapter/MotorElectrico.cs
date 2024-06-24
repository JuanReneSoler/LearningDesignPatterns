using System;

namespace patrones.Adapter
{
    public class MotorElectrico
    {
	bool _conectado;
	bool _activo;
	bool _moviendo;
	bool _isReady => _conectado && _activo;

	public void Conectar()
	{
	    if(_conectado)
		Console.WriteLine("Imposible conectar un motor electrico ya conectado.");
	    else
	    {
		_conectado = true;
		Console.WriteLine("Motor conectado!");
	    }
	}

	public void Activar()
	{
	    if(!_conectado)
		Console.WriteLine("Imposible Activar un motor no conectado");
	    else
	    {
		_activo = true;
		Console.WriteLine("Motor activado!");
	    }
	}

	public void Mover()
	{
	    if(_isReady)
	    {
		_moviendo = true;
		Console.WriteLine("Moviendo vehiculo con motor electrico.");
	    }
	    else
		Console.WriteLine("El motor deberia estar conectado y activo!");
	}

	public void Parar()
	{
	    if(_moviendo)
	    {
		_moviendo = false;
		Console.WriteLine("Parando vehiculo con motor electrico.");
	    }
	    else
		Console.WriteLine("Imposible parar un motor que no esta en movimiento!");
	}

	public void Desconectar()
	{
	    if(_conectado)
	    {
		_conectado = false;
		Console.WriteLine("Vehiculo electrico desconectado!");
	    }
	    else Console.WriteLine("No se puede desconectar un motor que no esta conectado.");
	}

	public void Desactivar()
	{
	    if(_activo)
	    {
		_activo = false;
		Console.WriteLine("Vehiculo electrico desactivado!");
	    } else Console.WriteLine("No se puede desactivar si no esta activo!");
	}

	public void Enchufar()
	{
	    if(!_activo)
	    {
		_activo = false;
		Console.WriteLine("Vehiculo cargando las baterias!");
	    } else Console.WriteLine("Imposible cargar un motor activo!");
	}
    }
}


