using System.Collections;

namespace patrones.Iterator
{
    public class PalabraIterator : IEnumerator
    {
	char[] _palabra;
	int _pos;

	public PalabraIterator(string palabra)
	{
	    _palabra = palabra.ToCharArray();
	    _pos = -1;
	}

	public object Current => _palabra[_pos];

	public bool MoveNext()
	{
	    var result = _pos < _palabra.Length - 1;

	    if(result)
		_pos++;

	    return result;
	}

	public void Reset() => _pos = -1;
    }
}
