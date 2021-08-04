using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge4
{
    public class UserMessageThread
    {
        [ForeignKey(nameof(User))]
        public List<User> UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(MessageThread))]
        public List<MessageThread> MessageThreadId { get; set; }
        public virtual MessageThread MessageThread { get; set; }
    }
}
