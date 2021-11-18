using System;
//using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace patrones.Interpreter
{
    public class Start
    {
	public static void RunPatron()
	{
	    string[] tree;
	    var context = new Context();
	    Console.Write("ingrese la operacion en letras: ");
	    var val = Console.ReadLine();
	    tree = val.Split(' ');
	    IExpression exp;
	    foreach(var t in tree)
	    {
		if(Operators.ConditionalCompareObjectGreaterEqual(context.GetInteger(t), 0, false))
		    exp = new NumericExpression(t);
		else
		    exp = new OperationExpression(t);

		exp.Interpret(context);
	    }

	    Console.WriteLine($"El resultado para {val} es {context.GetResult()}");
	}
    }
}
