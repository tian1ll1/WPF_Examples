using System;

namespace SampleChain
{
	class Class1
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string s = "5*(2+3)/(4-1)";
			Parser p = new Parser();
			Parser p1 = new Parser();

		

			System.Console.WriteLine(s);
			System.Console.WriteLine(p.Do(s));

			Computer c = new Computer(p1.ReturnStack(s));
			System.Console.WriteLine(c.Do());
			System.Console.ReadLine ();

		}
	}
}
