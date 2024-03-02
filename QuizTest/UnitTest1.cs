using Microsoft.AspNetCore.Http.HttpResults;
using QuizManagementSystem.Controllers;
using QuizManagementSystem.Models;

namespace QuizTest
{
    public class Tests
    {

        private QuizController controller;
        [SetUp]
        public void Setup()
        {
            controller = new QuizController();
        }

        [Test]
        public void TestMethodForGetQuiz()
        {
            IEnumerable<QuizModel> result = controller.GetQuiz();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostQuiz()
        {
            var newItem = new QuizModel
            {
                QuizId = 1,
                QuizTitle = "test",
                Category="test",
                NoOfQuestion=10,
                Maxmarks=20,
                Totaltime="test"

            };
            var actionResult = controller.PostQuiz(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostQuizNull()
        {
            var newItem = new QuizModel
            {
                QuizId = 1,
                QuizTitle = "null",
                Category = "null",
                NoOfQuestion = 0,
                Maxmarks = 0,
                Totaltime = "null"
            };
            var actionResult = controller.PostQuiz(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}