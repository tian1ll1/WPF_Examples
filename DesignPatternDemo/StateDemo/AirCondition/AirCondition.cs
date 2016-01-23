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
		
		//空调启动，输入目标温度和环境温度，输出功率
		public abstract double Do(double ttemp,double etemp);

	}
}
