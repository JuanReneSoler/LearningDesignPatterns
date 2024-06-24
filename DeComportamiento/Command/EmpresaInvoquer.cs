using System.Collections.Generic;

namespace patrones.Command
{
    public class EmpresaInvoquer
    {
	private List<OrderCommand> ordenes = new List<OrderCommand>();
	public void TomarOrden(OrderCommand command) => ordenes.Add(command);
	
	public void ProcesarOrdenes()
	{
	    foreach(var orden in ordenes)
		orden.Ejecutar();
	    ordenes.Clear();
	}
    }
}

