using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStoreByMaxOutputPerDay ������������������С��档
	/// </summary>
	public class CompMinStoreByMaxOutputPerDay:CompMinStore
	{
		public CompMinStoreByMaxOutputPerDay()
		{
			
		}

		public override long Comp(StoreContext sc)
		{
			return sc.MaxOutputPerDay * 10;
		}

	}
}
