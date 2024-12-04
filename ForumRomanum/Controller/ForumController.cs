using ForumMotor_13BC_A.Data;
using ForumMotor_13BC_A.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumRomanum.Controller
{
    public class ForumController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ForumController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<List<Category>> GetCategories()
        {
            var categories = _context.Categories.ToList();


            return Ok(categories);
        }
       /* public IActionResult Index()
        {
            return View();
        }*/
    }
}
