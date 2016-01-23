using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStoreByAvgOutput �������Сƽ�����������㡣
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
