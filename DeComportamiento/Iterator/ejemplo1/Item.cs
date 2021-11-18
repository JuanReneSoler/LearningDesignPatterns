
namespace patrones.Iterator
{
    public class Item
    {
	public string Nombre { get; set; }

	public Item(string nombre)
	{
	    Nombre = nombre;
	}

	public override string ToString() => Nombre;
    }
}
