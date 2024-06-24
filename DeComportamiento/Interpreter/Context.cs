using System.Collections.Generic;

namespace patrones.Interpreter
{
	public class Context
	{
		private string _nextOp = string.Empty;
		private int _operator = 0;
		private int _result = 0;
		private IDictionary<string, int> numbers = new Dictionary<string, int>
	{
		{"cero", 0},
		{"uno", 1},
		{"dos", 2},
		{"tres", 3},
		{"cuatro", 4},
		{"cinco", 5},
		{"seis", 6},
		{"siete", 7},
		{"ocho", 8},
		{"nueve", 9}
	};
		private IDictionary<string, string> operations = new Dictionary<string, string>
	{
		{"mas", "+"},
		{"menos", "-"}
	};

		public int GetInteger(string input) => numbers.ContainsKey(input.ToLower())
			? numbers[input.ToLower()] : -1;

		public void SetOperator(int op) => _operator = op;

		public void SetOperation(string operation)
		{
			if (operations.ContainsKey(operation.ToLower()))
				_nextOp = operations[operation.ToLower()];
		}

		public void Calculate()
		{
			if (_nextOp.Equals("+") || _nextOp.Equals(""))
				_result += _operator;

			if (_nextOp.Equals("-"))
				_result -= _operator;
		}

		public int GetResult() => _result;
	}
}
