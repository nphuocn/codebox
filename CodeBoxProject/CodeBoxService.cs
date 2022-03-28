using System.Collections.Generic;

namespace CodeBoxProject
{
    public class CodeBoxService
    {
        public static string GetCorrectAnswerFromCode(string codeText)
        {
            string answerText = string.Empty;
            if(string.IsNullOrEmpty(codeText))
            {
                return "NOT FOUND THE CORRECT ANSWER";
            }

            Dictionary<int, string> codeBoxList = new Dictionary<int, string>() {
                {1, "C" }, {2, "F" }, {3, "A" }, {4, "W" }, {5, "U" }, {6, "T" },
                {7, "Y" }, {8, "L" }, {9, "I" }, {10, "S" }, {11, "M" }, {12, "H" },
                {13, "R" }, {14, "N" }, {15, "Q" }, {16, "O" }, {17, "B" }, {18, "E" },
            };
            string[] codeParts = codeText.Split(' ');
            foreach (string codePart in codeParts)
            {
                string[] numbers = codePart.Split(',');
                foreach (string number in numbers)
                {
                    if (int.TryParse(number, out int correctNumber))
                    {
                        if (codeBoxList.TryGetValue(correctNumber, out string character))
                        {
                            answerText += character;
                        }
                        else
                        {
                            answerText += "^";
                        }
                    }
                    else
                    {
                        answerText += "%";
                    }
                }
                answerText += " ";
            }
            return answerText.TrimEnd();
        }
    }
}
