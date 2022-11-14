using Danske.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotificationSystemDanske.Entity;
using NotificationSystemDanske.Services.CompanyService;
using SQLitePCL;
using NotificationSchedule = NotificationSystemDanske.Models.NotificationSchedule;

namespace Danske.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class NotificationController : ControllerBase
    {

        public ICompanyService _CompanyService { get; }

        private readonly ICompanyService _companyService;

        public NotificationController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetAllCompany()
        {
            return await _companyService.GetAllCompany();
        }

        [HttpPost]
        public async Task<IActionResult> InsertNotifications(Company company)
        {
            if (await _companyService.InsertNotifications(company))
                return StatusCode(200);
            else
                return StatusCode(500);
        }
    }
}