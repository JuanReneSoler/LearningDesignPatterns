namespace patrones.Visitor.Ejemplo1
{
	public interface IVisitor
	{
		//void Visitar(Procesador componente);
		//void Visitar(PlacaBase componente);
		//void Visitar(DiscoRigido componente);

		void Visitar(string serial);
	}
}
