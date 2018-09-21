using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingNotes1.Web.Models
{
    //DTO
    public class MeetingModel
    {
        public int MeetingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
    }
}