using BigSchool.DTOs;
using BigSchool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.VisualBasic.ApplicationServices;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace BigSchool.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Atendance already exists!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();

        }
    }
}
