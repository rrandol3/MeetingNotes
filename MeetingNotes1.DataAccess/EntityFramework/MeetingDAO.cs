using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingNotes1.DataAccess.EntityFramework;
using MeetingNotes1.BusinessRules;
using AutoMapper;

namespace MeetingNotes1.DataAccess
{
    public class MeetingDAO : IMeetingDAO
    {
        public void DeleteMeeting(BusinessRules.Meeting meeting)
        {
            using (var context = new MeetingNotesEntities())
            {
                var entity = context.Meetings.SingleOrDefault(m => m.MeetingId == meeting.MeetingId);              
                context.Meetings.Remove(entity);
                context.SaveChanges();
            }
        }

        public BusinessRules.Meeting GetMeeting(int meetingId)
        {
            using (var context = new MeetingNotesEntities())
            {
                var meeting = context.Meetings.FirstOrDefault(m => m.MeetingId == meetingId);
                return Mapper.Map<EntityFramework.Meeting, BusinessRules.Meeting>(meeting);
            }
        }

        public List<BusinessRules.Meeting> GetMeetings(string userId)
        {
            using (var context = new MeetingNotesEntities())
            {
                var meetings = context.Meetings.Where(m => m.UserId == userId).ToList();
                return Mapper.Map<List<EntityFramework.Meeting>, List<BusinessRules.Meeting>>(meetings);
            }
        }

        public void SaveMeeting(BusinessRules.Meeting meeting)
        {
            using (var context = new MeetingNotesEntities())
            {
                var entity = Mapper.Map<BusinessRules.Meeting, EntityFramework.Meeting>(meeting);

                context.Meetings.Add(entity);
                context.SaveChanges();

                // update business object with new id
                meeting.MeetingId = entity.MeetingId;
            }
        }

        public void UpdateMeeting(BusinessRules.Meeting meeting)
        {
            using (var context = new MeetingNotesEntities())
            {
                var dbMeeting = context.Meetings.SingleOrDefault(m => m.MeetingId == meeting.MeetingId);
                dbMeeting.Name = meeting.Name;
                //dbMeeting.Notes = meeting.Notes;
                dbMeeting.Description = meeting.Description;
                dbMeeting.Date = DateTime.Now;
                context.SaveChanges();
            }
        }
    }
}
