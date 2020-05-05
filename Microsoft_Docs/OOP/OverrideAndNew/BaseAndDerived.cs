using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideAndNew
{
	class BaseClass
	{
		public virtual void Method1()
		{
			Console.WriteLine("Base - Method1");
		}

		public void Method2()
		{
			Console.WriteLine("Base - Method2");
		}
	}

	class DerivedClass : BaseClass
	{
		public override void Method1()
		{
			Console.WriteLine("Derived - Method1");
		}

		public new void Method2()
		{
			Console.WriteLine("Derived - Method2");
		}
	}
}
