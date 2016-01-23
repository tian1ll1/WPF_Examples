using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStoreByAvgOutput 按最大最小平均出库量计算。
	/// </summary>
	public class CompMinStoreByAvgOutput:CompMinStore
	{
		public CompMinStoreByAvgOutput()
		{
			
		}

		public override long Comp(StoreContext sc)
		{
			return (sc.MaxOutputPerDay + sc.MinOutputPerDay )/2 * 10;
		}

	}
}
