using System;

namespace CompMinStore
{
	/// <summary>
	/// CompMinStore ���������Ϳ��Ľӿڡ�
	/// </summary>
	public abstract class CompMinStore
	{
		public CompMinStore()
		{
		}

		public abstract long Comp(StoreContext sc);

	}
}
