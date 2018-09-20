using MeetingNotes1.DataAccess.EntityFramework;
using MeetingNotes1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingNotes1.Web.Controllers
{
    public class MeetingController : Controller
    {
        private IService service;
        public MeetingController() { service = new Service.Service(); }
        // GET: Meeting
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Meetings()
        //{
        //    string userId = string.Empty;
        //    var meetings = service.GetMeetings(Environment.UserName);
        //    return Json(meetings, JsonRequestBehavior.AllowGet);
        //}
        public ActionResult AddMeetings()
        {
            BusinessRules.Meeting meeting = new BusinessRules.Meeting();
            meeting.Name = "Test Meeting3";
            meeting.Description = "Test Meeting Description3";
            meeting.UserId = Environment.UserName;
            meeting.Date = DateTime.Now;
            service.SaveMeeting(meeting);
            return Content("Meetings added successfully!");
        }
    }
}