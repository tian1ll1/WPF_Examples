using System;

namespace AirCondition
{

	public class AirConditionControl
	{
		private AirCondition hot,cool,non,current;
		public AirConditionControl()
		{
			hot = new HotAirCondition();
			cool = new CoolAirCondition ();
			non = new NoAirCondition ();
			current = non;
		}

		public double UpTemp;
		public double DownTemp;
		
		public double TargetTemp;

		public string CurrentType
		{
			get{return current.GetType().Name;}
		}

		public double Do(double evtemp)
		{
			if (evtemp>UpTemp) current=cool;
			else if (evtemp<DownTemp) current=hot;
			else current=non;

			return current.Do(TargetTemp,evtemp);
		}
	}
}
