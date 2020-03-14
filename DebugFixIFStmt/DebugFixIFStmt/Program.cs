/* Ryan Hutton
 * Module 4 Coding Activity - Debug and fix If Statements
 * SNHU IT 230 - Software Development with C#.NET
 * 11/19/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixIFStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }


        void run()
        {
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

            System.Console.WriteLine("Ryan Hutton");

            firstChoice = 0; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 7;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
        }


        void WriteCurrentChoices(int firstChoice, int secondChoice, int thirdChoice)
        {
            if (firstChoice == 0)  // Changed secondChoice to firstChoice to satisfy non-zero precedence rule.
                Console.WriteLine("Choices are: {0}, {1}, {2} => There are no choices yet", firstChoice, secondChoice, thirdChoice);
            else if (secondChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}", firstChoice, secondChoice, thirdChoice, firstChoice);
            else if (thirdChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice);
            else if(thirdChoice != 0 )  // Changed == to != to check if thirdChoice did not contain the value of zero.
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}, {2}",
                    firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice, thirdChoice);
        }
    }
}
