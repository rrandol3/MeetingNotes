using MeetingNotes1.DataAccess;
using MeetingNotes1.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingNotes1.Service
{
    public class Service : IService
    {
        static readonly IMeetingDAO meetingDoa = new MeetingDAO();

        //Meeting Services
        public Meeting GetMeeting(int meetingId)
        {
            return meetingDoa.GetMeeting(meetingId);
        }

        public List<Meeting> GetMeetings(string userId)
        {
            return meetingDoa.GetMeetings(userId);
        }

        public void SaveMeeting(Meeting meeting)
        {
            meetingDoa.SaveMeeting(meeting);
        }
        public void DeleteMeeting(Meeting meeting)
        {
            meetingDoa.DeleteMeeting(meeting);
        }
        public void UpdateMeeting(Meeting meeting)
        {
            meetingDoa.UpdateMeeting(meeting);
        }
    }
}
