using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourThem.DataModels.Commands
{
    /*
     * As a User
     * I want to Start a Discussion
     * So that I can get feedback
     */
    #region Commands -  Start a Discussion
    public class ThreadPosting { }
    public class EditedThread { }
    public class DeletedThread { }
    #endregion

    /*
     * As a User
     * I want to Participate in a Discussion
     * So that I can gain reputation
     */
    #region Commands - Participate in a Discussion
    public class PostedReply { }
    public class EditedReply { }
    public class DeletedReply { }
    #endregion

    /*
     * As a User
     * I want to Flag Inappropriate Comments
     * So that Discussions are kept clean
     */
    #region Commands - Flag Inappropriate Comments
    public class FlaggedReply { }
    #endregion

    /*
     * As a Moderator
     * I want to Control Discussions and Replies
     * So that the forum content is in accordance with the rules of the site
     */
    #region Commands - Flag Inappropriate Comments
    public class ThreadApproval { }
    public class ThreadRejection { }
    public class RemovedReply { }
    #endregion
}
