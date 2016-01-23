using System;

namespace AirCondition
{
	
	public class HotAirCondition : AirCondition 
	{
		public HotAirCondition()
		{
			
		}
		//�ȿյ��������¶ȵ��������¶�ʱ����
		public override double Do(double ttemp, double etemp)
		{
			if (ttemp<etemp) return 0;
			return (ttemp - etemp) * 150 ;
		}

	}
}
