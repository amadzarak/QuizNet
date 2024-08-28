using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizNet.Models.Entities;
using QuizNet.Services;

namespace QuizNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public QuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetQuestions()
        {
            return Ok();
        }

        [HttpGet("topics/[controller]")]
        public IActionResult GetQuestionsByTopic()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateNewQuestion(Question question)
        {
            _ = new QuestionServices(_context).AddQuestion(question);
            return Ok(new { message = "Created New Question" });
        }
    }
}
