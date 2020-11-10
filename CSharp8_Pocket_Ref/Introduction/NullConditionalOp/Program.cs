namespace NullConditionalOp
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			System.Text.StringBuilder sb = null;
			string s = sb?.ToString ();	// No error; s is null.
			
			
		}
	}
}