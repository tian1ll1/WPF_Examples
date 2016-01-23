using System;

namespace SQLBuilder
{
	class Class1
	{
		
		[STAThread]
		static void Main(string[] args)
		{
			SQLBuilder sql = new SQLBuilderForSQLServer();
			string sqlstring = sql.BuilderSQL("TB","dt","2004-8-17");
			System.Console.WriteLine ("SQLServer:" + sqlstring);

			sql = new SQLBuilderForAccess ();
			sqlstring = sql.BuilderSQL("TB","dt","2004-8-17");
			System.Console.WriteLine ("Access:" + sqlstring);

			sql = new SQLBuilderForOracle ();
			sqlstring = sql.BuilderSQL("TB","dt","2004-8-17");
			System.Console.WriteLine ("Oracle:" + sqlstring);
		
			System.Console.ReadLine ();
		}
	}
}
