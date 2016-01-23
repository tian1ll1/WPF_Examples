using System;

namespace AirCondition
{
	
	public class HotAirCondition : AirCondition 
	{
		public HotAirCondition()
		{
			
		}
		//热空调，环境温度低于设置温度时工作
		public override double Do(double ttemp, double etemp)
		{
			if (ttemp<etemp) return 0;
			return (ttemp - etemp) * 150 ;
		}

	}
}
