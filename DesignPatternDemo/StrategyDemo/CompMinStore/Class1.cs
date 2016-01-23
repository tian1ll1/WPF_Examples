using System;

namespace CompMinStore
{
	class Class1
	{
		
		[STAThread]
		static void Main(string[] args)
		{
			StoreContext sc = new StoreContext ();

			sc.MinOutputPerDay = 20;
			sc.MaxOutputPerDay =50;

			CompMinStore s;

			s= new CompMinStoreByMinOutputPerDay ();
			sc.CompStraegy = s;
			Console.WriteLine (sc.CompStraegy.GetType().Name  + ":" + sc.Comp());

			s= new CompMinStoreByMaxOutputPerDay();
			sc.CompStraegy = s;
			Console.WriteLine (sc.CompStraegy.GetType().Name  + ":" + sc.Comp());

 			s= new CompMinStoreByAvgOutput();
			sc.CompStraegy = s;
			Console.WriteLine (sc.CompStraegy.GetType().Name  + ":" + sc.Comp());

			Console.ReadLine ();

		}
	}
}
