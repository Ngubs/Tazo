using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Tazo.DataAccess.Data;
using Tazo.Models.Entities;

namespace Tazo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(AppDbContext db) : ControllerBase
    {
        private readonly AppDbContext _db = db;

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourses()
        {
             return Ok(await _db.Courses.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(int id)
        {
            var courseObj = await _db.Courses.FindAsync(id);

            if(courseObj is null)
                return NotFound();
            return Ok(courseObj);
        }

        [HttpPost]
        public async Task<ActionResult<Course>> Create(Course course)
        {
            if(course is null )
                return BadRequest();

            _db.Courses.Add(course);    
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCourseById), new {id = course.CourseId}, course);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Course update)
        {
            var course = await _db.Courses.FindAsync(id);

            if(course is null )
                return NotFound();

            course.CourseCode = update.CourseCode;
            course.CourseTitle = update.CourseTitle;
            course.Year = update.Year;
            course.NQF = update.NQF;

            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _db.Courses.FindAsync(id);

            if (course is null)
                return NotFound();

            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
