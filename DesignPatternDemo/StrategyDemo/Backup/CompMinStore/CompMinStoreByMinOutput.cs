using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStoreByMinOutputPerDay 按日最小出库量计算库存。
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
