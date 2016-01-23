using System;

namespace SampleChain
{

	public class Computer
	{
		private Stack InStack;
		private Stack OutStack=new Stack();
		private TreatToken tk;
		public Computer(Stack inStk)
		{
			InStack=inStk;

			tk=new NumberToken(InStack,OutStack);
			tk.Next = new AddToken(InStack,OutStack);
			tk.Next.Next = new SubtractionToken(InStack,OutStack);
			tk.Next.Next.Next = new MultipToken(InStack,OutStack);
			tk.Next.Next.Next.Next = new DivisionToken(InStack,OutStack);

		}

		public string Do()
		{
			while(InStack.Count>0)
			{
				string s =InStack.Pop().ToString();
				tk.Treat(s);
			}
			return OutStack.Pop().ToString();
		}

	}
}
