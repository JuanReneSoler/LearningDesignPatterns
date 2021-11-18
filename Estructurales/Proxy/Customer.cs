

namespace patrones.Proxy
{
    public class Customer
    {
	string _name;

	public string Name { get => _name; }

	public Customer(string name)
	{
	    _name = name;
	}
    }
}


