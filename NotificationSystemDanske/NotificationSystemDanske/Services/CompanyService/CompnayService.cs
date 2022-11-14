using Danske.Data;
using Microsoft.EntityFrameworkCore;
using NotificationSystemDanske.Entity;

namespace NotificationSystemDanske.Services.CompanyService
{
    public class CompnayService : ICompanyService
    {

        private readonly DataContext _context;
    

        public CompnayService(DataContext context)
        {
           _context = context;
        }

        public async Task<List<Company>> GetAllCompany()
        {
            var company = await _context.Company.ToListAsync();
            return company;
        }

        public async Task<bool> InsertNotifications(Company company)
        {
            return true;
        }
    }
}
