using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NotificationSystemDanske.Entity
{
    public class NotificationSchedule
    {
        public int id { get; set; }

        public DateTime SendingDate { get; set; }

        public Guid Company_id { get; set; }

        public NotificationSchedule(Guid company_id, DateTime sendingDate)
        {
            SendingDate = sendingDate;
            Company_id = company_id;
        }
    }

}
