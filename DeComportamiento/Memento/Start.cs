using System;

namespace patrones.Memento
{
    public class Start
    {
	static CareTaker _careTaker = new CareTaker();
	public static void RunPatron()
	{
	    var person = new Persona();
	    
	    person.Nombre = "Pepe";
	    _careTaker.Add(person.SaveMemento());
	    
	    person.Nombre = "Pepe1";
	    _careTaker.Add(person.SaveMemento());

	    person.Nombre = "Pepe2";
	    _careTaker.Add(person.SaveMemento());

	    MementoObject m1 = _careTaker.GetMemento(0);
	    Console.WriteLine($"Viendo memento 1 {m1.Estado}");

	    m1 = _careTaker.GetMemento(1);
	    Console.WriteLine($"Viendo memento 2: {m1.Estado}");

	    m1 = _careTaker.GetMemento(2);
	    Console.WriteLine($"Viendo memento 3 {m1.Estado}");

	    person.RestoreMemento(m1);

	    person.RestoreMemento(_careTaker.GetMemento(1));
	}
    }
}
