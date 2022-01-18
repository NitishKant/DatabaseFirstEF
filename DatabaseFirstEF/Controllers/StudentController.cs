using DatabaseFirstEF.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirstEF.Controllers
{
    public class StudentController : Controller
    {
        public readonly StudentDbContext _db;

        public StudentController(StudentDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Students.ToList());
        }
    }
}
