using System;

namespace patrones.Proxy
{
    public class Start
    {
	public static void RunPatron()
	{
	    //
	    //Patron Proxy
	    //IRepository repo = new CustomerRepository();
	    /*IRepository repo = new CustomerRepositoryProxy();
	    
	    var custom = new Customer("custom 1");
	    var custom2 = new Customer("custom 2");

	    repo.Save(custom);
	    repo.Save(custom2);

	    foreach(var icustom in repo.GetAll())
	    {
		Console.WriteLine(icustom.Name);
	    }*/
	}
    }
}
