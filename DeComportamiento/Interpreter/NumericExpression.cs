namespace patrones.Interpreter
{
	public class NumericExpression : IExpression
	{
		private string _value;

		public NumericExpression(string token)
		{
			_value = token;
		}

		public void Interpret(Context context)
		{
			context.SetOperator(context.GetInteger(_value));
			context.Calculate();
		}
	}
}
