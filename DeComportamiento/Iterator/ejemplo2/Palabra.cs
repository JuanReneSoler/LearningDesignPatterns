using System.Collections;

namespace patrones.Iterator.Ejemplo2
{
    public class Palabra : IEnumerable
    {
	string _palabra;

	public Palabra(string palabra)
	{
	    _palabra = palabra;
	}

	public IEnumerator GetEnumerator() => new PalabraIterator(_palabra);
    }
}
