using System.Collections.Generic;

namespace patrones.Memento
{
    public class CareTaker
    {
	List<MementoObject> _mementos = new List<MementoObject>();
	public void Add(MementoObject memento) => _mementos.Add(memento);
	public MementoObject GetMemento(int index) => _mementos[index]; 
    }
}
