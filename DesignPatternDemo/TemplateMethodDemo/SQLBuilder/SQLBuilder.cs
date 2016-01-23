using System;

namespace SQLBuilder
{
	
	public abstract class SQLBuilder
	{
		public SQLBuilder()
		{
		}

		public string BuilderSQL(string TableName,string DateField,string DateValue)
		{
			string sql = "select * from ";
			sql = sql + TableName;
			sql = sql + " where ";
			sql = sql + DateField + "=";
			sql = sql + GetDateString(DateValue);
			return sql;
		}

		public abstract string GetDateString(string DataValue);
		
	}
}
