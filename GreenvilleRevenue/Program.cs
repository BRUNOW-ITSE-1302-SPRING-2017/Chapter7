// INSERT NAME HERE

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            String lastYearString;
            String thisYearString;
            int lastYear;
            int thisYear;
            int expectedRevenue;
            const int ENTRANCE_FEE = 25;

            WriteLine("Enter the number of contestants entered in last year's competition: ");
            lastYearString = ReadLine();
            lastYear = Convert.ToInt32(lastYearString);

            WriteLine("Enter the number of contestants entered in this year's competition: ");
            thisYearString = ReadLine();
            thisYear = Convert.ToInt32(thisYearString);

            WriteLine("Number of last year's contestants in the competition: {0}", lastYear);
            WriteLine("Number of this year's contestants in the competition: {0}", thisYear);
            WriteLine();

            expectedRevenue = ENTRANCE_FEE * thisYear;

			WriteLine("Expected revenue: {0}", expectedRevenue);

			WriteLine("There are more contestants this year than last: {0}", thisYear > lastYear);
        }
    }
}
