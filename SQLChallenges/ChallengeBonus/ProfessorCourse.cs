using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.ChallengeBonus
{
    public class ProfessorCourse
    {
        [ForeignKey(nameof(Professor))]
        public List<Professor> ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        [ForeignKey(nameof(Course))]
        public List<Course> CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
