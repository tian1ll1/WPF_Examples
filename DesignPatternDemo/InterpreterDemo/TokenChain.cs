using System;
using System.Reflection;

namespace InterpreterSample
{

	public class TokenChain
	{
		private string Token,TypeName;

		public TokenChain nextTokenChain=null;

		public TokenChain(string token,string typename)
		{
			Token=token;
			TypeName = typename;
		}

		public AbstractExpression Create(string token,int v)
		{
			if(token.ToLower()== Token.ToLower())
				return Create(v);
			else
			{
				if (nextTokenChain!=null)
					return nextTokenChain.Create(token,v);
       			else
					return null;
			}
		}

		private AbstractExpression Create(int v)
		{
			
			Type t = Type.GetType(TypeName);
			object [] s = {v};

			Object objName = Activator.CreateInstance(t,s);

			return (AbstractExpression)objName;
		}
	}
}
