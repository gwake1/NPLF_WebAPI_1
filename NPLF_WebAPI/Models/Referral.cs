using System;
using System.ComponentModel.DataAnnotations;

namespace NPLF_WebAPI.Models
{
    public partial class Referral
    {
        [Key]
        public int ReferralID { get; set; }
        [Required]
        public virtual RegisteredClient RegisteredClient { get; set; }
       
        public virtual Agency Agency { get; set; }
        [Required]
        public virtual ServiceCategory ServiceCategory { get; set; }
       
        public virtual AgencyEmployee AgencyEmployee {get; set;}
        [Required]
        public DateTime DateRequested { get; set; }
        public DateTime DateServiceRendered { get; set; }
       [Required]
        public bool ServiceRendered { get; set; }
        [Required]
        public bool ServiceInProgress { get; set; }
    }
}