using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningManagement.Interface;
using LearningManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningManagement.Repository
{
    public class Repository : IStudentRepository
    {
        private readonly AppDbContext _context;


        public Repository(AppDbContext context)
        {
            _context = context;
        }


        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }


        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
    }
}