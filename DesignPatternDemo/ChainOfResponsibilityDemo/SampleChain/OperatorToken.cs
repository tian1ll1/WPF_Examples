using System;

namespace SampleChain
{

	public class OperatorToken : TreatToken
	{
		private myOperator ope;
		
		public OperatorToken(Stack st,Stack stOut,myOperator op):base(st,stOut)
		{
			this.ope = op;
			
		}
		public override void Treat(string s)
		{
			if ( s == ope.Op) 
			{
				if (st.IsEmpty()||s=="(")
				{
					st.Push(ope);
				}
				else
				{
					myOperator o =(myOperator)st.TopItem();
					while (o.Level>=ope.Level||ope.Op==")")
					{
						myOperator o1 = (myOperator)st.Pop();
						if (o1.Op=="(")
						{
							break;
						}
						this.stOutput.Push(o1);
						if( st.IsEmpty()) break;
						o =(myOperator)st.TopItem();
					}
					if (ope.Op !=")")
						st.Push(ope);
				}
			}
			else
			{
				next.Treat(s);
			}
		}

	}
}
