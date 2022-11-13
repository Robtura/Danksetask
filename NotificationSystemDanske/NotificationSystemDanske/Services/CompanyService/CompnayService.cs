using Danske.Data;
using Microsoft.EntityFrameworkCore;

namespace NotificationSystemDanske.Services.CompanyService
{
    public class CompnayService : ICompanyService
    {
        private static List<Company> Company = new List<Company>
        {
            new Company
            {
                Id = 1,
                Name = "Danske",
            },
            new Company
            {
                Id = 2,
                Name = "Swedbank",
            }
        };

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
    }
}
