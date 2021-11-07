using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;
using TransNeftEnergoTest.DAL;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergoTest.API.Services;
using TransNeftEnergoTest.DAL.Models;

namespace TransNeftEnergoTest.API.Controllers
{
    [ApiController]
    [Route("api/measurement-points")]
    public class MeasurementPointController : ControllerBase
    {
        private readonly DatabaseContext dbContext;
        // private readonly MeasurementPointService mpService;

        public MeasurementPointController(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /*public MeasurementPointController(MeasurementPointService mpService)
        {
            this.mpService = mpService;
        }*/

        [HttpGet]
        public async Task<IEnumerable<MeasurementPointDTO>> Get()
        {
            return await dbContext.MeasurementPoints
                .Include(mp => mp.ElectricityMeter)
                .Include(mp => mp.CurrentTransformer)
                .Include(mp => mp.VoltageTransformer)
                .Select(mp => mp.ToDTO())
                .ToListAsync();
            // return await mpService.GetMeasurementPoints();
        }

        [HttpPost]
        public async Task<MeasurementPointDTO> AddPoint(MeasurementPointDTO dto)
        {
            if (dto == null) return null;
            var mp = new MeasurementPoint(dto);
            dbContext.MeasurementPoints.Add(mp);
            await dbContext.SaveChangesAsync();
            return mp.ToDTO();
            // return await mpService.Add(dto);
        }

    }
}
