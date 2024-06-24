namespace patrones.Flyweight
{
	public interface IFlyweight
	{
		void ColocaNombre(string nombre);
		void CalculaCosto();
		void Mostrar();
		string ObtenerNombre();
	}
}
