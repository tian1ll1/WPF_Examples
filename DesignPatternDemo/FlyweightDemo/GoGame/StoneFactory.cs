using System;
using System.Collections;
using System.Drawing;
namespace GoGame
{
	public class StoneFactory
	{
		private Stone blackstone,whitestone;

		#region 将棋子工厂定义为Singleton
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
		
		//'根据步数获得棋子,奇数为黑子,偶数为白子
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
