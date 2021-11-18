using System.Collections;

namespace patrones.Iterator
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
