namespace DefiningConstants
{
	static class Constants
	{
		public const double Pi = 3.14159;
		public const int SpeedOfLight = 300000;
	}
	
	class Program
	{
		public static void Main ( string [] args )
		{
			double radius = 5.3;
			double area = Constants.Pi * ( radius * radius );
			int secsFromSun = 149476000 / Constants.SpeedOfLight;
		}
	}
}