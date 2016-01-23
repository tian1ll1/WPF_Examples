using System;

namespace InterpreterSample
{
	/// <summary>
	/// AbstractExpression 这个抽象类代表终结类和非终结类的抽象
	/// 文法如下：
	/// expression :: = verb|repetition  var
	/// verb::=’left’|’right’|’forward’|’backward’
	/// repetition :: = ‘repeat’  (expression)
	/// </summary>
	public abstract class AbstractExpression
	{
		/// <summary>
		/// 解释相关环境下的命令
		/// </summary>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public abstract bool interpret(Context ctx);

	}
}
