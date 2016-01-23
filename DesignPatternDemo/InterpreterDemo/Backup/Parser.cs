using System;

namespace InterpreterSample
{

	public class Parser
	{
		private string strCommand;
		private string [] Commands;
		private TokenChain tc;
		public Parser(string s)
		{
			strCommand=s;	
			char c=' ';
			Commands = s.Split(c);
			TokenChain t1 = new TokenChain("left","InterpreterSample.LeftExpression");
			TokenChain t2 = new TokenChain("right","InterpreterSample.RightExpression");
            t1.nextTokenChain=t2;
			TokenChain t3 = new TokenChain("forward","InterpreterSample.ForwardExpression");
			t2.nextTokenChain = t3;
			TokenChain t4 = new TokenChain("backward","InterpreterSample.BackwardExpression");
			t3.nextTokenChain = t4;
			TokenChain t5 = new TokenChain("repeat","InterpreterSample.RepeatExpression");
			t4.nextTokenChain=t5;
			tc=t1;
   		}

		public AbstractExpression Build()
		{
			AbstractExpression a=null;
			RepeatExpression rp=null;


			for(int i=0;i<Commands.Length ; i=i+2)
			{
				string verb = Commands[i];
				string var = Commands[i+1];
				
				AbstractExpression b = tc.Create(verb,Convert.ToInt32(var));
				if (rp!=null) rp.AddExpression(b);
				if (b.GetType().Name=="RepeatExpression") rp = (RepeatExpression)b;
				if (i==0) a=b;
				
			}

			return a;
		}

	}
}
