namespace patrones.Visitor.Ejemplo1
{
	public abstract class Componente
	{
		string _serial;

		public Componente(string serial)
		{
			_serial = serial;
		}

		public string Serial
		{
			get => _serial;
		}

		//public abstract void Aceptar(IVisitor visitor);

		public void Aceptar(IVisitor visitor) => visitor.Visitar(_serial);
	}
}
