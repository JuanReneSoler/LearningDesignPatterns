

namespace patrones.Observer
{
    public class Usuario : IObserverUsuario
    {
	public Usuario(string nombre, string apellido)
	{
	    Nombre = nombre;
	    Apellido = apellido;
	}

	public string Nombre { get; set; }
	public string Apellido { get; set; }

	public override string ToString() => $"{Nombre} {Apellido}";

	public void Actualizar(Producto producto)
	{
	    //Form1 f = (Form1)Application.OpenForms[0];
	    //f.Notificar($"El usuario {this} recibio la notificacion del producto {producto}");
	}
    }
}
