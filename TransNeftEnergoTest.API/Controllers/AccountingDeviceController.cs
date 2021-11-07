using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DAL;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.API.Controllers
{
    [Route("api/accounting-devices")]
    [ApiController]
    public class AccountingDeviceController : ControllerBase
    {
        private readonly DatabaseContext dbContext;

        public AccountingDeviceController(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountingDeviceDTO>> GetAll()
        {
            return await dbContext.AccountingDevices.Select(ad => ad.ToDTO()).ToListAsync();
        }

        [HttpGet("{year}")]
        public async Task<IEnumerable<AccountingDeviceDTO>> GetByYear(int year)
        {
            return await dbContext.MeasurementPointToAccountingDevice
                .Where(mp2ad => mp2ad.From.Year <= year && mp2ad.To.Year >= year)
                .Select(mp2ad => mp2ad.AccountingDevice).Distinct().Select(ad => ad.ToDTO()).ToListAsync();
        }
    }
}
