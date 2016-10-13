using System.ComponentModel.DataAnnotations;

namespace NPLF_WebAPI.Models
{
    public class ServiceCategory
    {
        [Key]
        public int ServiceCategoryID { get; set; }
        [Required]
        public string ServiceCategoryName { get; set; }
        [Required]
        public string ServiceDescription { get; set; }
        [Required]
        public bool ActiveIndicator { get; set; }
    }
}