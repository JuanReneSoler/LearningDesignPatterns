
namespace patrones.Iterator.Ejemplo1
{
    public abstract class Collection
    {
	public abstract IteratorEjemplo CreateIterator();
	public abstract void Agregar(Item item);
	public abstract Item Index(int index);
	public abstract int Count();
	public abstract int Position();
    }
}
