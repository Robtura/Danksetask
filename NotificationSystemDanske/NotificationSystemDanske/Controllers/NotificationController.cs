using Danske.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotificationSystemDanske.Models;
using NotificationSystemDanske.Services.CompanyService;

namespace Danske.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public NotificationController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public ICompanyService _CompanyService { get; }

        /*public NotificationController(DataContext context)
        {
            context = context;
        }*/

        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetAllCompany()
        {
            return await _companyService.GetAllCompany();
        }
    }
}