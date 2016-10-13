using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPLF_WebAPI.Models
{
    public class AgencyService
    {
        public int AgencyServiceID { get; set; }
        public int ZipCode { get; set; }
        public bool ActiveServiceIndicator { get; set; }
        public virtual ICollection<ServiceCategory> ServiceCategories { get; set; }
    }
}