using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBoxProject;

namespace CodeBox.UnitTest
{
    [TestClass]
    public class CodeBoxUnitTest
    {
        [TestMethod]
        public void Test_Correct_Answer_From_Code_Box()
        {
            string codeBox = "11,3,7 6,12,18 2,16,13,1,18 17,18,4,9,6,12 7,16,5";
            string answerTedt = CodeBoxService.GetCorrectAnswerFromCode(codeBox);
            Assert.AreEqual("MAY THE FORCE BEWITH YOU", answerTedt);
        }
        [TestMethod]
        public void Test_Empty_Code_Box()
        {
            string codeBox = "";
            string answerText = CodeBoxService.GetCorrectAnswerFromCode(codeBox);
            Assert.AreNotEqual("MAY THE FORCE BEWITH YOU", answerText);
        }
        [TestMethod]
        public void Test_Invalid_Code_Box()
        {
            string codeBox = "check the text to find correct answer";
            string answerText = CodeBoxService.GetCorrectAnswerFromCode(codeBox);
            Assert.AreNotSame("MAY THE FORCE BEWITH YOU", answerText);
        }
        [TestMethod]
        public void Test_Not_Found_Code_Box()
        {
            string codeBox = "19,20,21 1,2,3";
            string answerText = CodeBoxService.GetCorrectAnswerFromCode(codeBox);
            Assert.AreNotSame("MAY THE FORCE BEWITH YOU", answerText);
        }
    }
}
