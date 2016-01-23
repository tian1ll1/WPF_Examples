using System;

namespace AirCondition
{
	
	public class NoAirCondition:AirCondition
	{
		public NoAirCondition()
		{
			
		}
		//²»¹¤×÷
		public override double Do(double ttemp, double etemp)
		{
			return 0;
		}

	}
}
