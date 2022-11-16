using Microsoft.Exchange.WebServices.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotificationSystemDanske.Models
{
    public class NotificationSchedule
    {
        [Column(Order = 1)]
        public string SendingDate { get; set; }

        public Guid Company_id { get; set; }

    }
}
