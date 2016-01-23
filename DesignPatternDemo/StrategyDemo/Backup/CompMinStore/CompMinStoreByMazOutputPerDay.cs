using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStoreByMaxOutputPerDay 按日最大出库量计算最小库存。
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
