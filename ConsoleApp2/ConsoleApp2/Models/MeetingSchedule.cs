using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class MeetingSchedule
    {
        private List<Meetings> _meetings;
       
        public void AddSetMeeting(Meeting meeting)
        {
            if (_meetings.Exists(m => m.FromDate ==meeting.FromDate && m.ToDate==meeting.ToDate)) 
            {
                throw new Exception();
            }
        }
    }
}
