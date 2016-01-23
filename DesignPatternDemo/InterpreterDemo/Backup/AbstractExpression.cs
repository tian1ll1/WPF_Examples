using System;

namespace InterpreterSample
{
	/// <summary>
	/// AbstractExpression �������������ս���ͷ��ս���ĳ���
	/// �ķ����£�
	/// expression :: = verb|repetition  var
	/// verb::=��left��|��right��|��forward��|��backward��
	/// repetition :: = ��repeat��  (expression)
	/// </summary>
	public abstract class AbstractExpression
	{
		/// <summary>
		/// ������ػ����µ�����
		/// </summary>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public abstract bool interpret(Context ctx);

	}
}
