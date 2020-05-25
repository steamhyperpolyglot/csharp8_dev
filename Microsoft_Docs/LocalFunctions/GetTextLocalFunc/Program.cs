using System;
using System.IO;

namespace GetTextLocalFunc
{
	class Program
	{
		static void Main ( string [] args )
		{
			string contents = GetText ( @"D:\RnD\csharp8_dev\Microsoft_Docs\temp", "example.txt" );
			Console.WriteLine("Contents of the file:\n" + contents);
		}

		private static string GetText ( string path, string filename )
		{
			var sr = File.OpenText ( AppendPathSeparator ( path ) + filename );
			var text = sr.ReadToEnd ();
			return text;
			
			// Declare a local function.
			string AppendPathSeparator ( string filepath )
			{
				if ( !filepath.EndsWith ( @"\" ) )
					filepath += @"\";

				return filepath;
			}
		}
	}
}