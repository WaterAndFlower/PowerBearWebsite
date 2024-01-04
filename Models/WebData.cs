using System.ComponentModel.DataAnnotations;

namespace PowerBearWebsite_Assembly.Models {
    public class WebData {
        [Key]
        public Guid Id { get; set; }
        public string IpAddress { get; set; } = "";
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string UserAgent { get; set; } = "";
    }
}
