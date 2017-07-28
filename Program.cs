using System;

namespace Mar02.Braile
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			string stop = "s";
			while (stop != "e")
			{
				Console.WriteLine("What is your message?");
				string message = Console.ReadLine().ToLower();
				//char[] message = message2.ToCharArray();
				//for (int i = 0; i < 1; i++)
				{
					for (int k = 0; k < message.Length; k++)
					{
						if (message[k] == 'a' || message[k] == 'b' || message[k] == 'e' || message[k] == 'h' || message[k] == 'k' || message[k] == 'l' || message[k] == 'o' || message[k] == 'r' || message[k] == 'u' || message[k] == 'v' || message[k] == 'z')
						{
							Console.Write("0O");
						}
						else if (message[k] == 'c' || message[k] == 'd' || message[k] == 'f' || message[k] == 'g' || message[k] == 'm' || message[k] == 'n' || message[k] == 'p' || message[k] == 'q' || message[k] == 'x' || message[k] == 'y')
						{
							Console.Write("00");
						}
						else if (message[k] == 'i' || message[k] == 'j' || message[k] == 's' || message[k] == 't' || message[k] == 'w')
						{
							Console.Write("O0");
						}
						else if (message[k] == ' ')
						{
							Console.Write(" ");
						}

					}
					Console.WriteLine();

					for (int l = 0; l < message.Length; l++)
					{
						if (message[l] == 'g' || message[l] == 'h' || message[l] == 'j' || message[l] == 'q' || message[l] == 'r' || message[l] == 't' || message[l] == 'w')
						{
							Console.Write("00");
						}
						else if (message[l] == 'b' || message[l] == 'f' || message[l] == 'i' || message[l] == 'l' || message[l] == 's' || message[l] == 'v' || message[l] == 'p')
						{
							Console.Write("0O");
						}
						else if (message[l] == 'd' || message[l] == 'e' || message[l] == 'n' || message[l] == 'o' || message[l] == 'y' || message[l] == 'z')
						{
							Console.Write("O0");
						}
						else if (message[l] == 'a' || message[l] == 'c' || message[l] == 'k' || message[l] == 'm' || message[l] == 'u' || message[l] == 's' || message[l] == 'x')
						{
							Console.Write("OO");
						}
						else if (message[l] == ' ')
						{
							Console.Write(" ");
						}

					}

					Console.WriteLine();
					for (int m = 0; m < message.Length; m++)
					{
						if (message[m] == 'u' || message[m] == 'v' || message[m] == 'x' || message[m] == 'y' || message[m] == 'z')
						{
							Console.Write("00");
						}
						else if (message[m] == 'k' || message[m] == 'l' || message[m] == 'm' || message[m] == 'n' || message[m] == 'o' || message[m] == 'p' || message[m] == 'q' || message[m] == 'r' || message[m] == 's' || message[m] == 't')
						{
							Console.Write("0O");
						}
						else if (message[m] == 'w')
						{
							Console.Write("O0");
						}
						else if (message[m] == 'a' || message[m] == 'b' || message[m] == 'c' || message[m] == 'd' || message[m] == 'e' || message[m] == 'f' || message[m] == 'g' || message[m] == 'h' || message[m] == 'i' || message[m] == 'j')
						{
							Console.Write("OO");
						}
						else if (message[m] == ' ')
						{
							Console.Write(" ");
						}





					}
					Console.WriteLine();

				}
				Console.WriteLine("Do you want to go again?");
				stop = Console.ReadLine();
			}


			}



		}
	}