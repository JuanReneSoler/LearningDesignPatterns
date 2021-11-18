
namespace patrones.Interpreter
{
    public class OperationExpression : IExpression
    {
	private string _operation;

	public OperationExpression(string token)
	{
	    _operation = token;
	}

	public void Interpret(Context context)
	{
	    context.SetOperation(_operation);
	}
    }
}
