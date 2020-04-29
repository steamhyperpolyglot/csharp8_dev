﻿using System;

namespace VariableScopeWithLambdas
{ 
	public class VariableCaptureGame
	{
		internal Action <int> updateCapturedLocalVariable;
		internal Func <int, bool> isEqualToCapturedLocalVariable;

		public void Run ( int input )
		{
			int j = 0;

			updateCapturedLocalVariable = x =>
			{
				j = x;
				bool result = j > input;
				Console.WriteLine ( $"{j} is greater than {input}: {result}" );
			};

			isEqualToCapturedLocalVariable = x => x == j;

			Console.WriteLine ( $"Local variable before lambda invocation: {j}" );
			updateCapturedLocalVariable ( 10 );
			Console.WriteLine ( $"Local variable after lambda invocation: {j}" );
		}
		
		public static void Main ( string [] args )
		{
			var game = new VariableCaptureGame ();

			int gameInput = 5;
			game.Run ( gameInput );
			int jTry = 10;
			bool result = game.isEqualToCapturedLocalVariable ( jTry );
			Console.WriteLine ( $"Captured local variable is equal to {jTry}: {result}" );

			int anotherJ = 3;
			game.updateCapturedLocalVariable ( anotherJ );

			bool equalToAnother = game.isEqualToCapturedLocalVariable ( anotherJ );
			Console.WriteLine ( $"Another lambda observes a new value of captured variable: {equalToAnother}" );
		}
	}
}