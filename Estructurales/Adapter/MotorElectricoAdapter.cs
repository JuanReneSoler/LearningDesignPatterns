namespace patrones.Adapter
{
	public class MotorElectricoAdapter : Motor
	{
		MotorElectrico _motorElectrico = new MotorElectrico();
		public override void Acelerar() => _motorElectrico.Mover();
		public override void Arrancar()
		{
			_motorElectrico.Conectar();
			_motorElectrico.Activar();
		}
		public override void CargarCombustible() => _motorElectrico.Enchufar();
		public override void Detener()
		{
			_motorElectrico.Desactivar();
			_motorElectrico.Parar();
		}
	}
}
