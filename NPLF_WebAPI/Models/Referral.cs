using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPLF_WebAPI.Models
{
    public class Referral
    {
        public int ReferralID { get; set; }
        public virtual RegisteredClient RegisteredClient { get; set; }
        public virtual AgencyService AgencyService { get; set; }
        public virtual ServiceCategory ServiceCategory { get; set; }

    }
}