using Microsoft.EntityFrameworkCore;
using QuizNet.Controllers;
using System;
using QuizNet.Models.Entities;

public class QuestionServices
{
    public readonly ApplicationDbContext _context;

    public QuestionServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddQuestion(Question question)
    {
        await _context.Questions.AddAsync(question);
        await _context.SaveChangesAsync();

    }
}

