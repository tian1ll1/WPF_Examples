using System;

namespace AirCondition
{
	
	public class CoolAirCondition :AirCondition
	{
		public CoolAirCondition()
		{
		}

		//冷空调，环境温度高于设置温度时工作
		public override double Do(double ttemp, double etemp)
		{
			if (ttemp>etemp) return 0;
			return (etemp - ttemp) * 200 ;
		}
	}
}
