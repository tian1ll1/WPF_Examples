using System;

namespace InterpreterSample
{

	public class LeftExpression:AbstractExpression
	{
		private int angle;
		public LeftExpression(int a)
		{
			angle = a;
		}
		public override bool interpret(Context ctx)
		{
			ctx.Angle= ctx.Angle + angle;
			ctx.DrawLocation();
			return true;
		}

	}
}
