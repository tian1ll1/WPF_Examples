using System;

namespace AirCondition
{
	
	public class NoAirCondition:AirCondition
	{
		public NoAirCondition()
		{
			
		}
		//������
		public override double Do(double ttemp, double etemp)
		{
			return 0;
		}

	}
}
