using System;

namespace SQLBuilder
{
	public class SQLBuilderForSQLServer:SQLBuilder
	{
		public SQLBuilderForSQLServer()
		{
		}
		public override string GetDateString(string DateValue)
		{
			return "'" + DateValue + "'";
		}
	}
}
