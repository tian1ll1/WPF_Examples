using System;

namespace SampleChain
{

	public class NumberToken:TreatToken
	{
		public NumberToken(Stack st,Stack stOut):base(st,stOut)
  		{
		}
		public override void Treat(string s)
		{
			if(Char.IsNumber(s,0))
			{
				this.stOutput.Push(s);
			}
			else
			{
				this.next.Treat(s);
			}
		}
	}
}
