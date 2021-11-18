
namespace patrones.Iterator
{
    public class ConcreteIteratorEjemplo : IteratorEjemplo
    {
	private Collection _aggregate;
	private Item _item;

	public ConcreteIteratorEjemplo(Collection agregado)
	{
	    _aggregate = agregado;
	}

	public override Item CurrentItem() => _item;
	public override void First() => _item = _aggregate.Index(0);
	public override bool IsDone() => _aggregate.Count() == _aggregate.Position() + 1;
	public override void Siguiente() => _item = _aggregate.Index(_aggregate.Position() + 1);
    }
}
