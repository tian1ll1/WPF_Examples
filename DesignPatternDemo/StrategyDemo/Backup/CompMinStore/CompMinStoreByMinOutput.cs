using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStoreByMinOutputPerDay ������С�����������档
	/// </summary>
	public class CompMinStoreByMinOutputPerDay:CompMinStore
	{
		public CompMinStoreByMinOutputPerDay()
		{
		}

		public override long Comp(StoreContext sc)
		{
			return sc.MinOutputPerDay * 10; 
		}

	}
}
