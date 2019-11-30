using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Service.Implementation;
using Service.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminKPIController : ControllerBase
    {
        private readonly IAdminKPIService _adminKPIService;
        private readonly IConfiguration _configuration;
        public AdminKPIController(
            IAdminKPIService adminKPIService, 
            IConfiguration configuration)
        {
            _adminKPIService = adminKPIService;
            _configuration =configuration;
        }

        // GET: api/KPI
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_adminKPIService.GetAll());
        }

        // GET: api/KPI/5
        [HttpGet("{id}/{page}", Name = "Get")]
        public IActionResult Get(int id, int? pageSize, string sortBy, int page = 1)
        {
            var catalog = new AdminKPIViewModel();
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");

            catalog.PageSize = pageSize;
            catalog.SortType = sortBy;
            catalog.Data = _adminKPIService.GetAllPaging(id, string.Empty, page, pageSize.Value);
           
            return Ok(catalog);
        }

        // POST: api/KPI
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/KPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
