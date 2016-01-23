using System;

namespace CompMinStore
{
	/// <summary>
	/// StoreContext 存储的上下文。
	/// </summary>
	public class StoreContext
	{
		public StoreContext()
		{

		}

		private long minOutputPerDay;
		private long maxOutputPerDay;
		private CompMinStore cs;

		public long MinOutputPerDay
		{
			get{return minOutputPerDay;}
			set{minOutputPerDay=value;}
		}

		public long MaxOutputPerDay
		{
			get{return maxOutputPerDay;}
			set{maxOutputPerDay=value;}
		}
		
		public CompMinStore CompStraegy
		{
			get{return cs;}
			set{cs = value;}
		}

		public long Comp()
		{
			return cs.Comp(this);
		}
		
	}
}
