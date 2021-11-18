using System;

namespace patrones.Singleton
{
    public class Start
    {
	public static void RunPatron()
	{
	    //probado para un unico hilo
	    var user = new Usuario
	    {
		UserName = "juansoler",
		Password = "1234"
	    };
	    SesionManager.Login(user);
	    var sm = SesionManager.Instance;

	    Console.WriteLine(sm.Usuario.UserName);

	    var sm2 = SesionManager.Instance;
	    Console.WriteLine(sm2.Usuario.UserName);

	    //singleton probado para varios hilos
	    /*Task.Run(()=>{
		    
		    var usr = new Usuario
		    {
		    	UserName = "juansoler",
			Password = "1234"
		    };

		    SesionManager.Login(usr);

		    var sm = SesionManager.Instance;

		    Console.WriteLine("Primer Hilo");
		    Console.WriteLine(sm.Usuario.UserName);

		    });

	    Task.Run(()=>{
		    
		    var usr = new Usuario
		    {
		    	UserName = "jrsoler",
			Password = "1234"
		    };

		    SesionManager.Login(usr);
		    var sm = SesionManager.Instance;

		    Console.WriteLine("Segundo Hilo");
		    Console.WriteLine(sm.Usuario.UserName);
		    
		    });*/
	}
    }
}
