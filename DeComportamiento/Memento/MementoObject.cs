namespace patrones.Memento
{
	public class MementoObject
	{
		string _estado;

		public MementoObject()
		{ }

		public MementoObject(string estado)
		{
			_estado = estado;
		}

		public string Estado
		{
			get => _estado;
		}
	}
}
