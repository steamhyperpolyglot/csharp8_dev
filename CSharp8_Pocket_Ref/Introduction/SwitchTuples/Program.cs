namespace SwitchTuples
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			int cardNumber = 12;
			string suite = "spades";
			string cardName = ( cardNumber, suite ) switch
			{
				(13, "spades") => "King of spades",
				(13, "clubs") => "King of clubs",
			};
		}
	}
}