using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPLF_WebAPI.Models
{
    public class Agency
    {
        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
        public int ZipCode { get; set; }
        public string EmailAddress { get; set; }
        public int AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string AltContactLastName { get; set; }
        public string AltContactFirstName { get; set; }
        public bool AgencyActiveIndicator { get; set; }
        public virtual ICollection<AgencyService> AgencyServices { get; set; }

    }
}