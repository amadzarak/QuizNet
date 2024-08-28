using Microsoft.EntityFrameworkCore;
using QuizNet.Controllers;
using System;
using QuizNet.Models.Entities;
using System.Xml.Linq;

using System.Linq;
namespace QuizNet.Services;

public class TopicServices
{
    public readonly ApplicationDbContext _context;
    public TopicServices(ApplicationDbContext context)
    {
        _context = context;

    }

    public IQueryable<Topic> GetAllTopics()
    {
        return _context.Topics.Select(t => t) ;
    }

    public async Task AddTopic(Topic topic)
    {
        await _context.Topics.AddAsync(topic);
        await _context.SaveChangesAsync();
    }
}