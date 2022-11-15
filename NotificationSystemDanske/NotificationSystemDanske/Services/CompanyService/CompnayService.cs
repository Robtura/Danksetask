using Danske.Data;
using Microsoft.EntityFrameworkCore;
using NotificationSystemDanske.Entity;
using NotificationSystemDanske.Models;

namespace NotificationSystemDanske.Services.CompanyService
{
    public class CompnayService : ICompanyService
    {

        private readonly DataContext _context;
    

        public CompnayService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<NotificationSchedule>> GetCompanyNotification(string entity_id)
        {
            var schedule = await _context.NotificationSchedule.Where(x => x.Company_id.ToString() == entity_id).ToListAsync();
            return schedule;
        }

        public async Task<bool> InsertNotifications(Company company)
        {
            var schedule = await _context.NotificationSchedule.ToListAsync();

            DateTime current= DateTime.Now;

            if (company.Market.Equals("Denmark"))
            {
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(5).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(10).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(15).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(20).ToString("dd/MM/yyyy")));
            }

            if (company.Market.Equals("Norway"))
            {
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(5).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(10).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(20).ToString("dd/MM/yyyy")));
            }

            if (company.Market.Equals("Sweden") && company.Type.Equals("small") && company.Type.Equals("medium"))
            {
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(7).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(14).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(28).ToString("dd/MM/yyyy")));
            }

            if (company.Market.Equals("Finland") && company.Type.Equals("large"))
            {
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(5).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(10).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(15).ToString("dd/MM/yyyy")));
                _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(20).ToString("dd/MM/yyyy")));
            }
            
            if (company.Market.Equals("Finland") && company.Type.Equals("corporate"))
            {
                _context.SaveChanges();
            }
            _context.SaveChanges();
            return true;
        }
    }
}
