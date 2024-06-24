using System;

namespace patrones.Memento
{
	public class Persona
	{
		public string Nombre { get; set; }

		public MementoObject SaveMemento()
		{
			Console.WriteLine($"Originador: Guardando memento para: {Nombre}");
			return new MementoObject(Nombre);
		}

		public void RestoreMemento(MementoObject memento)
		{
			Nombre = memento.Estado;
			Console.WriteLine($"Originador: Recuperando memento {Nombre}");
		}
	}
}
