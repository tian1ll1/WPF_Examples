using System;
using System.Collections;
using System.Drawing;
namespace GoGame
{
	public class StoneFactory
	{
		private Stone blackstone,whitestone;

		#region �����ӹ�������ΪSingleton
		private static StoneFactory _stonefactory=null;
		private StoneFactory()
		{
			blackstone = new Stone(Color.Black);
			whitestone = new Stone(Color.White);
		}

		public static StoneFactory Instance()
		{
			if (_stonefactory == null) 
				_stonefactory = new StoneFactory();
			return _stonefactory;
		}

		#endregion
		
		//'���ݲ����������,����Ϊ����,ż��Ϊ����
		public Stone GetStone(int n)
		{
			int m;
			int c = Math.DivRem(n,2,out m);
			if (m==1)
				return blackstone;
			else
				return whitestone;
		}



	}
}
