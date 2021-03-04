using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Data;
using TestApplication.DTO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly Context _context;

        public StudentsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudent()
        {
            var student = from students in _context.Student
                          join student_desctiptions in _context.Student_Description on students.id equals student_desctiptions.student_id
                          select new StudentDTO
                       {
                           Student_id = students.id,
                           Grade = students.grade,
                           Age = student_desctiptions.age,
                           First_name = student_desctiptions.first_name,
                           Last_name = student_desctiptions.last_name,
                           Adress = student_desctiptions.adress,
                           Country = student_desctiptions.country
                       };

            return await student.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<StudentDTO> GetStudent_byId(int id)
        {
            var student = from students in _context.Student
                          join student_desctiptions in _context.Student_Description on students.id equals student_desctiptions.student_id
                          select new StudentDTO
                          {
                              Student_id = students.id,
                              Grade = students.grade,
                              Age = student_desctiptions.age,
                              First_name = student_desctiptions.first_name,
                              Last_name = student_desctiptions.last_name,
                              Adress = student_desctiptions.adress,
                              Country = student_desctiptions.country
                          };

            var student_by_id = student.ToList().Find(x => x.Student_id == id);

            if (student_by_id == null)
            {
                return NotFound();
            }
            return student_by_id;
        }
    }
}