using MeetingNotes1.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingNotes1.DataAccess
{
    public interface IMeetingDOA
    {
        Meeting GetMeeting(int meetingId);
        List<Meeting> GetMeetings(string userId);
        void SaveMeeting(Meeting meeting);
        void DeleteMeeting(Meeting meeting);
        void UpdateMeeting(Meeting meeting);
    }
}
