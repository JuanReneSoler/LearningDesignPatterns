
namespace patrones.Adapter
{
    public class Start
    {
	public static void RunPatron()
	{
	    var motorNf = new MotorNaftero();
	    motorNf.Arrancar();
	    motorNf.Acelerar();
	    motorNf.Detener();
	    motorNf.CargarCombustible();

	    var motorDss = new MotorDissel();
	    motorDss.Arrancar();
	    motorDss.Acelerar();
	    motorDss.Detener();
	    motorDss.CargarCombustible();

	    var motorElectrico = new MotorElectricoAdapter();
	    motorElectrico.Arrancar();
	    motorElectrico.Acelerar();
	    motorElectrico.Detener();
	    motorElectrico.CargarCombustible();
	}
    }
}
