using System;

namespace AirCondition
{
	
	public abstract class AirCondition
	{
		public AirCondition()
		{
			
		}

		protected double targetTemp;

		public double TargetTemp
		{
			set{targetTemp=value;}
			get{return targetTemp;}
		}
		
		//�յ�����������Ŀ���¶Ⱥͻ����¶ȣ��������
		public abstract double Do(double ttemp,double etemp);

	}
}
