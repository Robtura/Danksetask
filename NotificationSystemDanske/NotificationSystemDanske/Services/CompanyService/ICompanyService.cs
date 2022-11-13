namespace NotificationSystemDanske.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<List<Company>> GetAllCompany(); //We list all aour methods to return.
    }
}
