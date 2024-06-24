
namespace patrones.Iterator.Ejemplo1
{
    public abstract class IteratorEjemplo
    {
	public abstract void First();
	public abstract void Siguiente();
	public abstract bool IsDone();
	public abstract Item CurrentItem();
    }
}
