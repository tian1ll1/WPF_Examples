using System;

namespace SampleChain
{

	public class myOperator
	{
		private string ope;
		private int level;
		public myOperator(string o, int l)
		{
			ope = o;
			level =l;
		}
		public string Op
		{
			get
			{
				return ope;
			}
		}

		public int Level
		{
			get
			{
				return level;
			}
		}

		public override string ToString()
		{
			return ope;
		}

	}
}
