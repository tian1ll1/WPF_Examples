
using System;

namespace SampleChain
{
	public abstract class CompToken:TreatToken
	{
		protected string token="";
		public CompToken (Stack st,Stack stOut):base(st,stOut)
		{
		}
		
		public override void Treat(string s)
		{
			if (s==token)
			{
				double b =Convert.ToDouble((string)this.stOutput.Pop()); 
				double a =Convert.ToDouble((string)this.stOutput.Pop());
				double c= Comp(a,b);
				this.stOutput.Push(c.ToString());
			}
			else
			{
				this.next.Treat(s);
			}
		}
		public abstract double Comp(double a, double b);

	}

	public class AddToken:CompToken
	{
		public AddToken(Stack st,Stack stOut):base(st,stOut)
		{
			token="+";
		}
		public override double Comp(double a, double b)
		{
			return a+b;
		}
	}

	public class SubtractionToken:CompToken
	{
		public  SubtractionToken(Stack st,Stack stOut):base(st,stOut)
		{
			token="-";
		}
		public override double Comp(double a, double b)
		{
			return a-b;
		}
	}

	public class MultipToken:CompToken
	{
		public  MultipToken(Stack st,Stack stOut):base(st,stOut)
		{
			token="*";
		}
		public override double Comp(double a, double b)
		{
			return a*b;
		}
	}

	public class DivisionToken:CompToken
	{
		public  DivisionToken(Stack st,Stack stOut):base(st,stOut)
		{
			token="/";
		}
		public override double Comp(double a, double b)
		{
			return a/b;
		}
	}

}
