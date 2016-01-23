using System;

namespace SQLBuilder
{
	
	public class SQLBuilderForAccess:SQLBuilder
	{
		public SQLBuilderForAccess()
		{
		}

		public override string GetDateString(string DateValue)
		{
			return "#" + DateValue + "#";
		}
	}
}
