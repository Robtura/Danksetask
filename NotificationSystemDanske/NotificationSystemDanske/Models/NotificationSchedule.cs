using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NotificationSystemDanske.Models
{
    public class NotificationSchedule
    {
        public string? SendingDate { get; set; }

        [Key]
        [Column("Company_id")]
        public int Company_id { get; set; }

        public NotificationSchedule(int company_id, string sendingDate)
        {
            SendingDate = sendingDate;
            Company_id = company_id;
        }
    }

}
