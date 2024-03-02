using Microsoft.AspNetCore.Mvc;
using QuizManagementSystem.Models;

namespace QuizManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private static List<QuizModel> quizs = new List<QuizModel> { };

        // GET: api/<QuizController>
        [HttpGet]
        public IEnumerable<QuizModel> GetQuiz()
        {
            return quizs;
        }

        [HttpPost]
        public IActionResult PostQuiz(QuizModel quiz)
        {
            quizs.Add(quiz);
            return Ok(quiz);
        }
    }
}
