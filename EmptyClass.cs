using System;

namespace ChessBoard
{
	public class GenerateBoard
	{
		public static void Main ()
		{

			int boardSize = 8;

			for (int x = 0; x < boardSize; x++) {
				for (int y = 0; y < boardSize; y++) {
					if (x % 2 == 0) {
						if (y % 2 == 0) {
							
							Console.Write ("[ ] ");

						} else {
							
							Console.Write ("{ } ");


						}
					} else {

						if (y % 2 == 0) {
							
							Console.Write ("{ } ");


						} else {
							
							Console.Write ("[ ] ");

						}
					}

				}

					Console.WriteLine ("");
			}

		}
	}
}

