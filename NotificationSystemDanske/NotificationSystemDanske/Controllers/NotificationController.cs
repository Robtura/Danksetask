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

        [HttpGet("{entity_id}")]
        public async Task<ActionResult<NotificationSchedule>> GetEntityidNotification(string entity_Id)
        {
            //return await _companyService.GetCompanyId();

            var resultid = _companyService.GetCompanyNotification(entity_Id);
            if (resultid is null)
                return NotFound("No Company found.");
            return Ok(resultid);
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