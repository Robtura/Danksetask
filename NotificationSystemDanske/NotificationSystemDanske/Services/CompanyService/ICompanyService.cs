using Microsoft.Exchange.WebServices.Data;
using NotificationSystemDanske.Entity;

namespace NotificationSystemDanske.Services.CompanyService
{
    public interface ICompanyService
    {
        //Task<List<NotificationSchedule>> GetCompanyNotification(NotificationSchedule id, string sendingdate); //We list all our methods to return.

        Task<List<NotificationSchedule>> GetCompanyNotification(string entity_id);

        Task<bool> InsertNotifications(Company company); 


    }
}
