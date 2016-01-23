using System;

namespace SampleChain
{

	public abstract class TreatToken
	{
		//用来处理Token的临时堆栈
		protected Stack st;

		//用来保存结果的堆栈
		protected Stack stOutput;

		//Next构成职责链
		protected TreatToken next;

		public TreatToken Next
		{
			set
			{
				next=value;
			}
			get
			{
				return next;
			}
		}
        public TreatToken(Stack st,Stack stOut)
		{
			this.st=st;
			this.stOutput=stOut;
		}

		public abstract void Treat(string s);
	}
}
