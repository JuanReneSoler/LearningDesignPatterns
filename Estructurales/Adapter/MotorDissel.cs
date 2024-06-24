using System;

namespace patrones.Adapter
{
    public class MotorDissel : Motor
    {
	public override void Acelerar() => Console.WriteLine("Acelerando el motor Dissel.");
	public override void Arrancar() => Console.WriteLine("Arrancando el motor Dissel.");
	public override void CargarCombustible() => Console.WriteLine("Cargando combustible del motor Dissel.");
	public override void Detener() => Console.WriteLine("Deteniendo el motor Dissel.");
    }
}


