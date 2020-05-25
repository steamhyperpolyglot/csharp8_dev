using System;

namespace Referencing
{
	public class SampleRefType
	{
		public int value;
	}
	
	class Program
	{
		static void Main ( string [] args )
		{
			SampleRefType rt = new SampleRefType ();
			rt.value = 44;
			ModifyObject ( rt );
			Console.WriteLine ( rt.value );
		}

		static void ModifyObject ( SampleRefType obj )
		{
			obj.value = 33;
		}
	}
}