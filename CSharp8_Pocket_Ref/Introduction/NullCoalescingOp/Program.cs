namespace NullCoalescingOp
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			string s1 = null;
			string s2 = s1 ?? "nothing";	// s2 evaluates to "nothing"
		}
	}
}