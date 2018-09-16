using MeetingNotes1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MeetingNotes1.Controllers
{
    public class MeetingController : Controller
    {
        IService service { get; set; }
        MeetingController() : this(new Service.Service()) { }
        MeetingController(IService service)
        {
            this.service = service;
        }
        // GET: Meeting
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Meetings()
        {
            string userId = string.Empty;
            var meetings = service.GetMeetings(userId);
            return View();
        }      
    }
}