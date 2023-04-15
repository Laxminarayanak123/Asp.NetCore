using System;
using System.Collections.Generic;

namespace Lms_Db.Model
{
    public partial class LmsMembers
    {
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string City { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime? DateExpire { get; set; }
        public string MembershipStatus { get; set; }
    }
}
