using System;
namespace ProCSharp
{
	public class MyDerivedClass: HisBaseClass
	{
		public MyDerivedClass()
		{
		}

		public new int MyGroovyMethod()
		{
			// some groovy implementation
			return 0;
		}
	}
}
