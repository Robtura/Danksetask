using Danske.Data;
using Microsoft.EntityFrameworkCore;
using NotificationSystemDanske.Entity;

namespace NotificationSystemDanske.Services.CompanyService
{
    public class CompnayService : ICompanyService
    {
        //private static list<company> company = new list<company>
        //{
        //    new company
        //    {
        //        id = 1,
        //        name = "danske",
        //    },
        //    new company
        //    {
        //        id = 2,
        //        name = "swedbank",
        //    }
        //};

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
