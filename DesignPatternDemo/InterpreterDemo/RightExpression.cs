using System;

namespace InterpreterSample
{

	public class RightExpression:AbstractExpression
	{
		private int angle;
		public RightExpression(int a)
		{
			angle = a;
		}

		public override bool interpret(Context ctx)
		{
			ctx.Angle= ctx.Angle - angle;
			ctx.DrawLocation();
			return true;
		}
	}
}
