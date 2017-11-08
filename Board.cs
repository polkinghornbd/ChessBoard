using System;

namespace ChessBoard
{
	public class GenerateBoard
	{
		public static void Main ()
		{

			int boardSize = 8;
			// The standard size of a chessboard is 8 tiles, and I don't know
			// how I would generate pieces for a larger board, so I might consider
			// hardcoding this wherever it is needed, but in the beginning for 
			// testing purposes, it might be good to be able to change it in
			// all directions.

			for (int x = 0; x < boardSize; x++)
			{
				int work;
				for (work = 0; work < 3; work++)
				{


					for (int y = 0; y < boardSize; y++)
					{
						int please;
						for (please = 0; please < 3; please++)
						{

							if (x % 2 == 0)
							{
								if (y % 2 == 0)
								{

									// Prints a White tile when both rows are even, IE x = 4, y = 6

									Console.BackgroundColor = ConsoleColor.White;
									Console.ForegroundColor = ConsoleColor.White;
									// First, it colors both the front font and the back font the same color.
									// See below for discussion on why.
									Console.Write("\u2591");
									Console.Write("\u2591");
									// Then it prints Unicode 2591, which is a light shading, which I would
									// eventually like to add as the actual tile picture, but at this point
									// It doesn't look right, so I have it blend in with the background for now.
									// For a look at what 2591 looks like check here
									// www.fileformat.info/info/unicode/char/2591/index.htm
									Console.ResetColor();
									// Finally, the console color is reset, just in case it isn't set the next
									// time I iterate a tile.  It might be possible to set up this with for loops
									// instead of if/else statements, but that's just a though in the back of 
									// my mind right now, so I'm not sure it would work.

								}
								else
								{

									// Prints a Black tile when x is even but y is odd, IE x = 4, y = 7

									Console.BackgroundColor = ConsoleColor.Black;
									Console.ForegroundColor = ConsoleColor.Black;
									Console.Write("\u2591");
									Console.Write("\u2591");
									Console.ResetColor();
								}
							}
							else
							{

								if (y % 2 == 0)
								{

									// Prints a Black tile if X is odd but Y is even, IE x = 7, y = 2

									Console.BackgroundColor = ConsoleColor.Black;
									Console.ForegroundColor = ConsoleColor.Black;
									Console.Write("\u2591");
									Console.Write("\u2591");
									Console.ResetColor();
								}
								else
								{

									// Prints a White tile if both rows are Odd, IE x = 3, y = 7.

									// There's probably a better way to do this than two if/else 
									// statements nested within an if/else statement, but at the 
									// moment I cannot think of one that would be easy to do right
									// now.  Later, I will need to iterate over this with the 
									// positions the pieces are at, but I'll cross that bridge 
									// when I get to it.

									Console.BackgroundColor = ConsoleColor.White;
									Console.ForegroundColor = ConsoleColor.White;
									Console.Write("\u2591");
									Console.Write("\u2591");
									Console.ResetColor();
								}
							}

						}

					}

					Console.WriteLine("");
				}
			}
		}
	}
}

