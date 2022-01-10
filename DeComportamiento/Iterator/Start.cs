using patrones.Iterator.Ejemplo1;
using patrones.Iterator.Ejemplo2;

namespace patrones.Iterator
{
    public class Start
    {
	private static void Ejemplo1() => new UI().Load();
	private static void Ejemplo2()
	{
	    var palabra = new Palabra("hola");
	    foreach(var c in palabra)
		System.Console.WriteLine(c);
	}
	public static void RunPatron()
	{
	    //Ejemplo1();
	    Ejemplo2();
	}
    }
}
