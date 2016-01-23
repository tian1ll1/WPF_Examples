using System;

namespace SampleChain
{

	public class Parser
	{
		public Stack sttemp = new Stack();
		public Stack stOutput = new Stack();
		TreatToken tk;

		public Parser()
		{
			NumberToken nt = new NumberToken(sttemp,stOutput);
			OperatorToken op1 =new OperatorToken(sttemp,stOutput,new myOperator("+",10));
			OperatorToken op2 =new OperatorToken(sttemp,stOutput,new myOperator("-",10));
			OperatorToken op3 =new OperatorToken(sttemp,stOutput,new myOperator("*",11));
			OperatorToken op4 =new OperatorToken(sttemp,stOutput,new myOperator("/",11));
			OperatorToken op5 =new OperatorToken(sttemp,stOutput,new myOperator("(",9));
			OperatorToken op6 =new OperatorToken(sttemp,stOutput,new myOperator(")",8));
			OperatorToken op7 =new OperatorToken(sttemp,stOutput,new myOperator(")",12));


			OtherToken ot= new OtherToken();

			nt.Next = op1;
			op1.Next=op2;
			op2.Next=op3;
			op3.Next=op4;
			op4.Next=op5;
			op5.Next=op6;
			op6.Next =op7;
			op7.Next=ot;

			tk=nt;
			
		}

		public string Do(string s)
		{
			for(int i=0;i<s.Length;i++)
				tk.Treat(s.Substring(i,1));

			
			while(!sttemp.IsEmpty())
				stOutput.Push(sttemp.Pop());

			string sout ="";

            while(!stOutput.IsEmpty())
				sout = stOutput.Pop().ToString() + " " + sout;
			return sout;
			
		}
		
		public Stack ReturnStack(string s)
		{
			for(int i=0;i<s.Length;i++)
				tk.Treat(s.Substring(i,1));

			while(!sttemp.IsEmpty())
				stOutput.Push(sttemp.Pop());

			while(!stOutput.IsEmpty())
				sttemp.Push(stOutput.Pop());

			return sttemp;
		}
	}
}
