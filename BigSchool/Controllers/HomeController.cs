using BigSchool.Models;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using BigSchool.ViewModels;
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        {
            _dbContext = new ApplicationDbContext();
=======
        {
            _dbContext = new ApplicationDbContext();
=======
        {
            _dbContext = new ApplicationDbContext();
=======
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcominngCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category).Where(c => c.DateTime > DateTime.Now);
            return View(upcominngCourses);

>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
        }
        public ActionResult Index()
        {
            var upcominngCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category).Where(c => c.DateTime > DateTime.Now);
            return View(upcominngCourses);

>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
        }
        public ActionResult Index()
        {
            var upcominngCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category).Where(c => c.DateTime > DateTime.Now);
            return View(upcominngCourses);

>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
        }
        public ActionResult Index()
        {
            var upcominngCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CourseViewModel
            {
                UpcommingCourses = upcominngCourses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewModel);

        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}