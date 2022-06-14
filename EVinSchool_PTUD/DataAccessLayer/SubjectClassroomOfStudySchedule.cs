using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SubjectClassroomOfStudySchedule
    {
        public int StudyId { get; set; }
        public int? ClassId { get; set; }
        public DateTime? StudyDate { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public string SubjectName { get; set; }
        public string ClassName { get; set; }
    }
}
