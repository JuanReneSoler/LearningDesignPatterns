using System.Collections.Generic;

namespace patrones.Iterator.Ejemplo1
{
    public class ConcreteCollection : Collection
    {
	private List<Item> _listaItems = new List<Item>();
	private Item _item;
	private int _position;

	public override IteratorEjemplo CreateIterator() => new ConcreteIteratorEjemplo(this);
	public override void Agregar(Item item) => _listaItems.Add(item);
	public override Item Index(int index)
	{
	    _item = _listaItems[index];
	    _position = index;
	    return _item;
	}
	public override int Count() => _listaItems.Count;
	public override int Position() => _position;
    }
}
