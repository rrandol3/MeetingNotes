using MeetingNotes1.DataAccess;
using MeetingNotes1.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingNotes1.BusinessRules;

namespace MeetingNotes1.Service
{
    // ** Facade pattern.
    // ** Repository pattern (Service could be split up in individual Repositories)
    public class Service : IService
    {
        static readonly IMeetingDAO meetingDoa = new MeetingDAO();

        //Meeting Services
        public BusinessRules.Meeting GetMeeting(int meetingId)
        {
            return meetingDoa.GetMeeting(meetingId);
        }

        public List<BusinessRules.Meeting> GetMeetings(string userId)
        {
            return meetingDoa.GetMeetings(userId);
        }

        public void SaveMeeting(BusinessRules.Meeting meeting)
        {
            meetingDoa.SaveMeeting(meeting);
        }
        public void DeleteMeeting(BusinessRules.Meeting meeting)
        {
            meetingDoa.DeleteMeeting(meeting);
        }
        public void UpdateMeeting(BusinessRules.Meeting meeting)
        {
            meetingDoa.UpdateMeeting(meeting);
        }
    }
}
