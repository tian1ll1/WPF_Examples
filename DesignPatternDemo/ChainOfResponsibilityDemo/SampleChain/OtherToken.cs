using System;

namespace SampleChain
{

	public class OtherToken:TreatToken
	{
		public OtherToken():base(null,null)
		{}

		public override void Treat(string s)
		{
			if (s!=" ") 
				throw new Exception("无法识别的操作符"+s);
		}
 
	}
}
