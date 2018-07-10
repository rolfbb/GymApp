using System;
using System.Collections.Generic;

namespace GymApp.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; }

        // Navigational property
        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }
    }
}