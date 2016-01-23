using System;

namespace InterpreterSample
{

	public class ForwardExpression:AbstractExpression
	{
		private int Length;
		public ForwardExpression(int l)
		{
			Length=l;
		}

		public override bool interpret(Context ctx)
		{
			double a = FAngle(ctx.Angle);
			double x= ctx.LocationX + Length * Math.Cos(a);
			double y =ctx.LocationY + Length * Math.Sin(a);
			ctx.LocationX=(int)x;
			ctx.LocationY =(int)y;
			ctx.DrawLocation();
			return true;
		}

		private double FAngle(int a)
		{
			double da = (double)a;
			return da * Math.PI/180.0;
		}

	}
}
