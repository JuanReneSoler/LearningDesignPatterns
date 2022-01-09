using System;

namespace patrones.State
{
    public class Start
    {
	public static void RunPatron()
	{
	    Switch sw = new Switch();
	    sw.Presionar();
	    sw.Presionar();
	    sw.Presionar();
	    sw.Presionar();
	    sw.Presionar();
	    sw.Presionar();

	    Console.ReadKey();
	}
    }
}
