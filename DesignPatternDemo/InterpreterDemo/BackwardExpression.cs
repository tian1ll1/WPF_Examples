using System;

namespace InterpreterSample
{

	public class BackwardExpression:AbstractExpression
	{
		private ForwardExpression f;
		public BackwardExpression(int l)
		{
			f = new ForwardExpression(-l);
		}

		public override bool interpret(Context ctx)
		{
			return f.interpret(ctx);
		}

	}
}
