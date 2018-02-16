using FourThem.DataModels.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourThem.BLL
{
    [DataObject]
    public class ForumPostController
    {
        public void PostNewThread(ThreadPosting data) { }
        public void EditThread(EditedThread data) { }
        public void DeleteThread(DeletedThread data) { }

        public void PostReply(PostedReply data) { }
        public void EditReply(EditedReply data) { }
        public void DeleteReply(DeletedReply data) { }
    }
    [DataObject]
    public class ForumModerationController
    {
        public void ApproveThread(ThreadApproval data) { }
        public void RejectThread(ThreadRejection data) { }
        public void RemoveReply(RemovedReply data) { }
    }
    [DataObject]
    public class ForumQueryController
    {
    }
}
