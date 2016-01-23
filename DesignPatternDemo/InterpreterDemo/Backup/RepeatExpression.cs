using System;
using System.Collections;

namespace InterpreterSample
{
	
	public class RepeatExpression:AbstractExpression
	{
		private ArrayList rg= new ArrayList();
		private int RepeatNumber;

		public RepeatExpression(int r)
		{
			RepeatNumber = r;
		}

		public void AddExpression(AbstractExpression ex)
		{
			rg.Add(ex);
		}

		public override bool interpret(Context ctx)
		{
			for(int i=1;i<RepeatNumber;i++)
				foreach(AbstractExpression e in rg)
					e.interpret(ctx);
			return true;
		}

	}
}
