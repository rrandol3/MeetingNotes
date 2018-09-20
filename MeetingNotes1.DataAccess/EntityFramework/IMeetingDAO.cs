using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingNotes1.BusinessRules;

namespace MeetingNotes1.DataAccess
{
    public interface IMeetingDAO
    {
        Meeting GetMeeting(int meetingId);
        List<Meeting> GetMeetings(string userId);
        void SaveMeeting(Meeting meeting);
        void DeleteMeeting(Meeting meeting);
        void UpdateMeeting(Meeting meeting);
    }
}
