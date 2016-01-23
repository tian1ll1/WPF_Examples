using System;

namespace SampleChain
{

	public abstract class TreatToken
	{
		//��������Token����ʱ��ջ
		protected Stack st;

		//�����������Ķ�ջ
		protected Stack stOutput;

		//Next����ְ����
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
