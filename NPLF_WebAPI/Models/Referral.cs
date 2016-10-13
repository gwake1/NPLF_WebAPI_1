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
        [Required]
        public virtual Agency Agency { get; set; }
        [Required]
        public virtual ServiceCategory ServiceCategory { get; set; }
        [Required]
        public virtual AgencyEmployee AgencyEmployee {get; set;}
        [Required]
        public DateTime DateRequested { get; set; }
        public bool ServiceDelivered { get; set; }
    }
}