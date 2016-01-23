using System;
using System.Collections;

namespace SampleChain
{

	public class Stack
	{
		private ArrayList myStack ;
		
		public Stack()
		{
			myStack = new ArrayList();
		}

		public void Push(object o)
		{
			myStack.Add (o);
		}

		public object Pop()
		{
			int idx =myStack.Count -1;
			if (idx<0) 
				throw new Exception("¶ÑÕ»ÒÑ¿Õ");
			object o = myStack[idx];
			myStack.Remove(o);
			return o;
		}

		public bool IsEmpty()
		{
			return (myStack.Count==0);
		}

		public object TopItem()
		{
			int idx =myStack.Count -1;
			if (idx<0) 
				throw new Exception("¶ÑÕ»ÒÑ¿Õ");
			object o = myStack[idx];
			return o;
		}
		public int Count
		{
			get
			{return myStack.Count;}
		}


	}
}
