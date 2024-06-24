

namespace patrones.AbstractFactory
{
    public class PizzeriaArgentina : Pizzeria
    {
	public override Pizza CreatePizza()
	{
	    return new PizzaCapresa();
	}

	public override Empanada CreateEmpanada()
	{
	    throw new System.NotImplementedException();
	}
    }
}



