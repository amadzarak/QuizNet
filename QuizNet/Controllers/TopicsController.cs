using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizNet.Models.Entities;
using QuizNet.Services;




namespace QuizNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TopicsController(ApplicationDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllTopics()
        {
            var topics = new TopicServices(_context).GetAllTopics();
            return Ok(new { topics });
        }

        [HttpPost]
        public IActionResult CreateNewTopics(Topic topic)
        {
            _ = new TopicServices(_context).AddTopic(topic);
            return Ok(new { message = "Created TOPICS" });
        }
    }
}
