using Danske.Data;
using Microsoft.EntityFrameworkCore;
using NotificationSystemDanske.Entity;
using NotificationSystemDanske.Services.CompanyService;
namespace NotificationSystemDanske.Entity;

public class CompnayService : ICompanyService
{

    private readonly DataContext _context;

    public CompnayService(DataContext context)
    {
        _context = context;
    }

   /* public async Task<List<Entity.NotificationSchedule>> GetCompanyNotification(Guid entity_id)
    {
        var schedule = await _context.NotificationSchedule.Where(x => x.Company_id/*.ToString()// == entity_id).ToListAsync();
        return schedule;
    }*/

    public async Task<List<NotificationSystemDanske.Models.NotificationSchedule>> GetCompanyNotification(Guid id)
    {
        var schedule = await _context.NotificationSchedule.Where(x => x.Company_id == id)
            .Select(x => new Models.NotificationSchedule
            {
                Company_id = x.Company_id,
                SendingDate = x.SendingDate.ToString("dd/MM/yyyy")
            })
        .ToListAsync();
        return schedule;
    }

    public async Task<bool> InsertNotifications(Company company)
    {

        var schedule = await _context.NotificationSchedule.ToListAsync();

        DateTime current = DateTime.Now;

        if (company.Market.Equals("Denmark"))
        {
            /* _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
             _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(5).ToString("dd/MM/yyyy")));
             _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(10).ToString("dd/MM/yyyy")));
             _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(15).ToString("dd/MM/yyyy")));
             _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(20).ToString("dd/MM/yyyy")));*/

            _context.NotificationSchedule.Add(new Entity.NotificationSchedule(company.Id, current.AddDays(1)));
            _context.NotificationSchedule.Add(new Entity.NotificationSchedule(company.Id, current.AddDays(5)));
            _context.NotificationSchedule.Add(new Entity.NotificationSchedule(company.Id, current.AddDays(10)));
            _context.NotificationSchedule.Add(new Entity.NotificationSchedule(company.Id, current.AddDays(15)));
            _context.NotificationSchedule.Add(new Entity.NotificationSchedule(company.Id, current.AddDays(20)));
        }

        if (company.Market.Equals("Norway"))
        {
            /*_context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(5).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(10).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(20).ToString("dd/MM/yyyy")));*/

            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(1)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(5)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(10)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(20)));
        }

        if (company.Market.Equals("Sweden") && company.Type.Equals("small") && company.Type.Equals("medium"))
        {
            /*_context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(7).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(14).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(28).ToString("dd/MM/yyyy")));*/

            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(1)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(7)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(14)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(28)));
        }

        if (company.Market.Equals("Finland") && company.Type.Equals("large"))
        {
            /*_context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(1).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(5).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(10).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(15).ToString("dd/MM/yyyy")));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Entity_Id, current.AddDays(20).ToString("dd/MM/yyyy")));*/

            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(1)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(5)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(10)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(15)));
            _context.NotificationSchedule.Add(new NotificationSchedule(company.Id, current.AddDays(20)));
        }

        _context.Company.Add(company);
        _context.SaveChanges();

        return true;
    }
}


