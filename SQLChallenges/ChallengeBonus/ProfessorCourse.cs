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
        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
