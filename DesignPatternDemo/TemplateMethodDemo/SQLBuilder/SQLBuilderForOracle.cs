using System;

namespace SQLBuilder
{
	public class SQLBuilderForOracle:SQLBuilder
	{
		public SQLBuilderForOracle()
		{
			
		}
		public override string GetDateString(string DateValue)
		{
			return "ToDate(" + DateValue +")";
		}
	}
}
