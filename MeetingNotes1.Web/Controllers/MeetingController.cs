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
        IService service { get; set; }
        //MeetingController() : this(new Service.Service()) { }
        MeetingController(IService service)
        {
            this.service = service;
        }
        public MeetingController() { this.service = new Service.Service(); }
        // GET: Meeting
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Meetings()
        {
            string userId = string.Empty;
            var meetings = service.GetMeetings(Environment.UserName);
            return Json(meetings, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddMeetings()
        {
            Meeting meeting = new Meeting();
            meeting.Name = "Test Meeting2";
            meeting.Description = "Test Meeting Description2";
            meeting.UserId = Environment.UserName;
            meeting.Date = DateTime.Now;
            service.SaveMeeting(meeting);
            return Content("Meetings added successfully!");
        }
    }
}