using NotificationSystemDanske.Entity;

namespace NotificationSystemDanske.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<List<Company>> GetAllCompany(); //We list all our methods to return.

        Task<bool> InsertNotifications(Company company);

    }
}
