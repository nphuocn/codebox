using System;

namespace CodeBoxProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type a code box and press enter
            Console.WriteLine("Select a code box number (from 1 to 18): ");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string codeText = Console.ReadLine();
            if(string.IsNullOrEmpty(codeText))
            {
                Console.WriteLine("Please select code box numbers");
                return;
            }
            else
            {
                string answerText = CodeBoxService.GetCorrectAnswerFromCode(codeText);
                Console.WriteLine($"Correct answer from code: {answerText}");
            }
        }
    }
}
