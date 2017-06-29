using CourseExamples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseExamples.Exercises
{
    public class Exercise1 : IExercise
    {
        public Exercise1() { }
        public void Solve()
        {
            Console.WriteLine("Hello World!");
        }

        #region Helpers
        /// <summary>
        /// Reads a number entered in the console, this function will repeat itself until it receives a valid int.
        /// </summary>
        /// <returns>the parsed int which can be used for further processing</returns>
        public static int ReadNumber()
        {
            int result = 0;
            bool validNumberHasBeenRead = false;
            do
            {
                string input = FlexibleRead("Waiting for number input:");
                validNumberHasBeenRead = Int32.TryParse(input, out result);
            } while (!validNumberHasBeenRead);
            return result;
        }

        /// <summary>
        /// Reads text entered in the console, if not given valid entry this function will keep on being executed
        /// </summary>
        /// <returns>the text input entered</returns>
        public static string ReadText()
        {
            return FlexibleRead("waiting for text input:");

        }

        public static string FlexibleRead(string prompt)
        {
            string textEntry = string.Empty;
            bool textEntryIsValid = false;
            do
            {
                Console.WriteLine(prompt);
                textEntry = Console.ReadLine();
                if (string.IsNullOrEmpty(textEntry))
                {
                    Console.WriteLine("Give some valid input please!");
                }
                else
                {
                    textEntryIsValid = true;
                }
            } while (!textEntryIsValid);
            return textEntry;
        }

        /// <summary>
        /// avoids the program window from closing until additional text input is given.
        /// </summary>
        public static void EndProgram()
        {
            Console.WriteLine("Press the any key to finish this program. Kappa");
            Console.ReadKey();
        }
        #endregion
    }
}
