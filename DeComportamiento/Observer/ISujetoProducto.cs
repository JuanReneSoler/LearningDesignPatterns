

namespace patrones.Observer
{
    public interface ISujetoProducto
    {
	void Agregar(IOberverUsuario usuario);
	void Quitar(IObserverUsuario usuario);
	void Notificar();
    }
}
