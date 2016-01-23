using System;

namespace AirCondition
{
	
	public class CoolAirCondition :AirCondition
	{
		public CoolAirCondition()
		{
		}

		//��յ��������¶ȸ��������¶�ʱ����
		public override double Do(double ttemp, double etemp)
		{
			if (ttemp>etemp) return 0;
			return (etemp - ttemp) * 200 ;
		}
	}
}
