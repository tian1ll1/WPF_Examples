using System;

namespace AirCondition
{
	/// <summary>
	/// Class1 ��ժҪ˵����
	/// </summary>
	class Class1
	{
		/// <summary>
		/// Ӧ�ó��������ڵ㡣
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
