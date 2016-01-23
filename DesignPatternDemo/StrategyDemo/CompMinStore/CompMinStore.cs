using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStore 定义计算最低库存的接口。
	/// </summary>
	public abstract class CompMinStore
	{
		public CompMinStore()
		{
		}

		public abstract long Comp(StoreContext sc);

	}
}
