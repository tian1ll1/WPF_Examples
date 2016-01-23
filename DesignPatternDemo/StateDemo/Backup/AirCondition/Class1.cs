using System;

namespace AirCondition
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	class Class1
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			AirConditionControl ac= new AirConditionControl();
			ac.DownTemp = 16;
			ac.UpTemp =26;
			ac.TargetTemp = 22;
			
			Console.WriteLine (ac.Do(30));
			Console.WriteLine (ac.CurrentType);

			Console.WriteLine (ac.Do(25));
			Console.WriteLine (ac.CurrentType);

			Console.WriteLine (ac.Do(4));
			Console.WriteLine (ac.CurrentType);

			Console.ReadLine ();

		}
	}
}
