using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourThem.Entities
{
    [Table("Forum_Topics")]
    internal class Topic
    {
        [Key]
        public int TopicID { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Discussion> Discussions { get; set; } = new HashSet<Discussion>();
    }
    internal abstract class AbstractMessage
    {
        public string Text { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
    [Table("Forum_Discussions")]
    internal class Discussion : AbstractMessage
    {
        [Key]
        public int DiscussionID { get; set; }
        public string Title { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }

        public int TopicID { get; set; }
        public virtual Topic Topic { get; set; }

        public virtual ICollection<Reply> Replies { get; set; } = new HashSet<Reply>();
    }
    [Table("Forum_Replies")]
    internal class Reply : AbstractMessage
    {
        [Key]
        public int ReplyID { get; set; }
        public bool Flagged { get; set; }
        public bool Removed { get; set; }
        public string RemovedBy { get; set; }
        public string RemovalReason { get; set; }

        public int DiscussionID { get; set; }
        public virtual Discussion Discussion { get; set; }

        [ForeignKey("RepliedTo")]
        public int? RepliedToID { get; set; }
        public virtual Reply RepliedTo { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }
    }
}
