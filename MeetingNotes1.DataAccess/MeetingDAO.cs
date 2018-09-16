using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingNotes1.DataAccess.EntityFramework;

namespace MeetingNotes1.DataAccess
{
    public class MeetingDAO : IMeetingDAO
    {
        public void DeleteMeeting(Meeting meeting)
        {
            using (var context = new MeetingNotesEntities())
            {
                context.Meetings.Remove(meeting);
            }
        }

        public Meeting GetMeeting(int meetingId)
        {
            using (var context = new MeetingNotesEntities())
            {
                return context.Meetings.FirstOrDefault(m => m.MeetingId == meetingId);
            }
        }

        public List<Meeting> GetMeetings(string userId)
        {
            using (var context = new MeetingNotesEntities())
            {
                return context.Meetings.Where(m => m.UserId == userId).ToList();
            }
        }

        public void SaveMeeting(Meeting meeting)
        {
            using (var context = new MeetingNotesEntities())
            {
                context.Meetings.Add(meeting);
                context.SaveChanges();
            }
        }

        public void UpdateMeeting(Meeting meeting)
        {
            using (var context = new MeetingNotesEntities())
            {
                var dbMeeting = context.Meetings.FirstOrDefault(m => m.MeetingId == meeting.MeetingId);
                dbMeeting.Name = meeting.Name;
                dbMeeting.Notes = meeting.Notes;
                dbMeeting.Description = meeting.Description;
                dbMeeting.Date = DateTime.Now;
                context.SaveChanges();
            }
        }
    }
}
