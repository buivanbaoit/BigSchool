using BigSchool.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcominngCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category).Where(c => c.DateTime > DateTime.Now);
            return View(upcominngCourses);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}