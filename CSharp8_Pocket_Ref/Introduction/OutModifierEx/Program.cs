﻿using System;

namespace OutModifierEx
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			int x;
			int.TryParse ( "123", out x );
			Console.WriteLine ( x );
		}
	}
}