using System;

namespace patrones.AbstractFactory
{
    public class Start
    {
	public static void RunPatron()
	{
            Pizzeria fabrica;

	    fabrica = new PizzeriaItaliana();
	    //fabrica = new PizzeriaArgentina();

	    var pizza = fabrica.CreatePizza();
	    var empanada = fabrica.CreateEmpanada();

	    Console.WriteLine($"{pizza.Descripcion} and {empanada.Descripcion}");
	}
    }
}
