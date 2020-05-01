using System;
using System.Globalization;

namespace HexToFloat
{
	class Program
	{
		public static void Main ( string [] args )
		{
			string hexString = "43480170";
			uint num = uint.Parse ( hexString, NumberStyles.AllowHexSpecifier );

			byte [] floatVals = BitConverter.GetBytes ( num );
			float f = BitConverter.ToSingle ( floatVals, 0 );
			Console.WriteLine ( "float convert = {0}", f );
		}
	}
}