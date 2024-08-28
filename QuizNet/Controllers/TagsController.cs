using QuizNet.Models.Entities;
using System.Linq;
namespace QuizNet.Controllers
{
    public class TagsController
    {
        public readonly ApplicationDbContext _context;

        TagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddTagToQuestion()
        {

        }
    }
}
