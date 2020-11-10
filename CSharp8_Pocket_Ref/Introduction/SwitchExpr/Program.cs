namespace SwitchExpr
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			int cardNumber = 13;
			string cardName = cardNumber switch
			{
				13 => "King",
				12 => "Queen",
				11 => "Jack",
				_ => "Pip card"		// equivalent to 'default'
			};
		}
	}
}