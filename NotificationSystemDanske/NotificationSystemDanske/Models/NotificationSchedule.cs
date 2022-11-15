using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NotificationSystemDanske.Models
{
    public class NotificationSchedule
    {
        public int id { get; set; }

        public string? SendingDate { get; set; }

        public string Company_id { get; set; }

        public NotificationSchedule(string company_id, string sendingDate)
        {
            SendingDate = sendingDate;
            Company_id = company_id;
        }
    }

}
