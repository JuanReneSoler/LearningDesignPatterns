
namespace patrones.Iterator
{
    public class Start
    {
	public static void RunPatron()
	{
	    //ejemplo 1
	    //var ui = new UI();
	    //ui.Run();
	    
	    //ejemplo 2
	    var palabra = new Palabra("hola");
	    foreach(var c in palabra)
		System.Console.WriteLine(c);
	}
    }
}
