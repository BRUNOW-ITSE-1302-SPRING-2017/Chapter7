// INSERT NAME HERE

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
	class Program
	{
		static void Main()
		{
			int lastYearContestants = 0;
			int thisYearContestants = 0;

			WriteLine();
			lastYearContestants = GetNumberOfParticipants("How many contestants were there LAST year? (Answer must be GREATER THAN 0 AND LESS THAN OR EQUAL TO 30)", lastYearContestants);
			WriteLine();

			thisYearContestants = GetNumberOfParticipants("How many contestants were there THIS year? (Answer must be GREATER THAN 0 AND LESS THAN OR EQUAL TO 30)", thisYearContestants);
			WriteLine();

			DisplayContestantCountRelationship(thisYearContestants, lastYearContestants);
			WriteLine();

			string[] contestantNames = new string[thisYearContestants];
			string[] contestantTalents = new string[thisYearContestants];

			FillTalentArrays(contestantTalents, contestantNames);
			WriteLine();

			DisplayTalentTotals(contestantTalents);

			ShowTalentLists(contestantNames, contestantTalents);
		}

		// method that gets and returns a valid number of contestants and is called twice -- once for last year's number of contestants and once for this year's value
		public static int GetNumberOfParticipants(string prompt, int number)
		{
			do
			{
				WriteLine(prompt);
				number = Convert.ToInt32(ReadLine());

			} while (number < 0 || number > 30);

			return number;
		}

		// method that accepts the number of contestants this year and last year and displays one of the three messages the describes the relationship between the two contestant values
		public static void DisplayContestantCountRelationship(int thisYearTotal, int lastYearTotal)
		{
			// compare the competition
			if (thisYearTotal > (2 * lastYearTotal))
			{
				// twice as many contestants as last year
				WriteLine("The competition is more than twice as big this year!");
			}
			else if (thisYearTotal >= lastYearTotal && thisYearTotal <= (2 * lastYearTotal))
			{
				// bigger than last year's but not more than twice as big
				WriteLine("The competition is bigger than ever!");
			}
			else
			{
				// competition is smaller than last year's
				WriteLine("A tighter race this year! Come out and cast your vote!");
			}
		}

		// method that fills the array of competitors and their talent codes
		public static void FillTalentArrays(string[] contestantTalents, string[] contestantNames)
		{
			// Valid input
			for (int index = 0; index < contestantTalents.Length; index++)
			{
				contestantTalents[index] = GetTalentFromUser();

				WriteLine("Please tell me contestant #{0}'s name:", index + 1);
				contestantNames[index] = ReadLine();
				WriteLine();
			}
		}

		static string GetTalentFromUser()
		{
			string talent = "";

			while (talent.ToLower() != "s" && talent.ToLower() == "d" && talent.ToLower() == "m" && talent.ToLower() == "o")
			{
				WriteLine("Enter a category of talent. S for singing, D for dancing,");
				WriteLine("M for playing a musical instrument, or O for other.");
				talent = Console.ReadLine();
			}

			return talent;
		}

		static void DisplayTalentTotals(string[] talents)
		{
			int singingCount = 0; // totall number of singers
			int dancingCount = 0; // totall number of dancers
			int musicalCount = 0; // totall number of musicans
			int otherCount = 0; // totall number of others

			foreach (string talent in talents)
			{
				if (talent.ToLower() == "s")
				{
					singingCount++; // add to singing total
				}
				else if (talent.ToLower() == "d")
				{
					dancingCount++; // add to dancing total
				}
				else if (talent.ToLower() == "m")
				{
					musicalCount++; // add to musical total
				}
				else if (talent.ToLower() == "o")
				{
					otherCount++; // add to other total
				}
			}

			WriteLine();
			WriteLine("The total number of singers is {0}.", singingCount);
			WriteLine("The total number of dancers is {0}.", dancingCount);
			WriteLine("The total number of musicians is {0}.", musicalCount);
			WriteLine("The total number of others is {0}.", otherCount);
			WriteLine("The total number of all contestants is {0}.", talents.Length);
			WriteLine();
		}

		// method that lists the talents
		static void ShowTalentLists(string[] contestantNames, string[] contestantTalents)
		{
			string userInput;
			string talent;

			do
			{
				WriteLine("");
				WriteLine("Enter S to list the singers in the competition.");
				WriteLine("Enter D to list the dancers in the competition.");
				WriteLine("Enter M to list the musicians in the competition.");
				WriteLine("Enter O to list the others in the competition.");
				WriteLine("Enter '*' to exit the program. ");
				userInput = ReadLine();

				for (int index = 0; index < contestantNames.Length; index++)
				{
					talent = contestantTalents[index];

					if (talent.ToLower() == "s" && userInput.ToLower() == "s")
					{
						WriteLine("{0} is a singer", contestantNames[index]); // write singers
					}
					else if (talent.ToLower() == "d" && userInput.ToLower() == "d")
					{
						WriteLine("{0} is a dancer.", contestantNames[index]); // write dancer
					}
					else if (talent.ToLower() == "m" && userInput.ToLower() == "m")
					{
						WriteLine("{0} is a musician.", contestantNames[index]); // write musicial
					}
					else if (talent.ToLower() == "o" && userInput.ToLower() == "o")
					{
						WriteLine("{0} is an other.", contestantNames[index]); // write other
					}
					else if (userInput.ToLower() != "s" && userInput.ToLower() != "d" && userInput.ToLower() != "m" && userInput.ToLower() != "o" && userInput != "*")
					{
						WriteLine("INVALID RESPONSE!");
						break;
					}
				}
			} while (userInput != "*");
		}
	}
}
