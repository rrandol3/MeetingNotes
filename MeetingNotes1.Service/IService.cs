using MeetingNotes1.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingNotes1.BusinessRules;

namespace MeetingNotes1.Service
{
    public interface IService
    {
        //Meeting Repository
        BusinessRules.Meeting GetMeeting(int meetingId);
        List<BusinessRules.Meeting> GetMeetings(string userId);
        void SaveMeeting(BusinessRules.Meeting meeting);
        void DeleteMeeting(BusinessRules.Meeting meeting);
        void UpdateMeeting(BusinessRules.Meeting meeting);
    }
}
