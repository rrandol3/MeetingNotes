using MeetingNotes1.DataAccess.EntityFramework;
using MeetingNotes1.Service;
using MeetingNotes1.Web.Models;
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
        public MeetingController()
        {
            service = new MeetingNotes1.Service.Service();
        }
        // GET: Meeting
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetMeeting()
        {
            var meeting = service.GetMeeting(2);
            var model = AutoMapper.Mapper.Map<BusinessRules.Meeting, MeetingModel>(meeting);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
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