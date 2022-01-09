using System;
using System.Collections.Generic;
using Core.patrones;

namespace patrones.Observer
{
    public class ProductosUI : BaseUI
    {
	private readonly List<ISujetoProducto> _productos;
	private readonly SelectList _selectList;

	public ProductosUI()
	{
	    _productos = new List<ISujetoProducto>
	    {
		new Producto("Producto 1", 1.5),
		new Producto("Producto 2", 2.33),
		new Producto("Producto 3", 5.33)
	    };
	    _selectList = new SelectList();
	    _selectList.AddRange(_productos);
	    this.Add(_selectList);
	}

	protected override void OnKeyPress(ConsoleKeyInfo keyInfo)
	{
	    if(keyInfo.Key == ConsoleKey.UpArrow) _selectList.Previous();
	    if(keyInfo.Key == ConsoleKey.DownArrow) _selectList.Next();
	    if(keyInfo.Key == ConsoleKey.Enter) SelectUsuario();
	    if(keyInfo.Key == ConsoleKey.E) EditProductPrice();
	}

	public void EditProductPrice()
	{
	    Console.Clear();
	    var product = _productos[_selectList.GetSelectedIndex() - 1] as Producto;
	    Console.Write($"Ingrese el nuevo precio del producto:{product}: ");
	    var strVal = Console.ReadLine();
	    var o = 0.0;
	    if(double.TryParse(strVal, out o))
	    {
		if(o > 0.0)
		{
		    product.Precio = o;
		    _productos[_selectList.GetSelectedIndex() - 1] = product;
		}
	    }
	    Console.Clear();
	}

	private void SelectUsuario()
	{
	    var producto = _productos[_selectList.GetSelectedIndex() - 1];
	    var usuariosUI = new UsuariosUI(producto);
	    usuariosUI.Load();
	}

	protected override string AddTextToTemplate() 
	    => $@"
Press E to Edit Product Price

Notificaciones:
{string.Join('\n', Notificaciones)}";

	private static IList<string> _notificacions;
	public static IList<string> Notificaciones
	{
	    get
	    {
		if(_notificacions == null)
		    _notificacions = new List<string>();
		return _notificacions;
	    }
	    set => _notificacions = value;
	}
	public static void Notificar(string notificacion) => Notificaciones.Add(notificacion);
    }
}
