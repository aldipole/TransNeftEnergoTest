using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DAL;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.API.Services
{
    [Route("api/consumption-units")]
    [ApiController]
    public class ConsumptionUnitController : ControllerBase
    {
        private readonly DatabaseContext dbContext;

        public ConsumptionUnitController(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<ConsumptionUnitDTO>> GetAll()
        {
            return await dbContext.ConsumptionUnits
                .Include(cu => cu.SupplyPoints)
                .Include(cu => cu.MeasurementPoints)
                .Select(cu => cu.ToDTO())
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public ConsumptionUnitDTO GetById(int id)
        {
            return dbContext.ConsumptionUnits
                .Include(cu => cu.SupplyPoints)
                .Include(cu => cu.MeasurementPoints)
                .First(cu => cu.ID == id)
                .ToDTO();
        }

        [HttpGet("{id}/electricity-meters")]
        public async Task<IEnumerable<ElectricityMeterDTO>> GetElectricityMeters(int id)
        {
            return await dbContext.ElectricityMeters
                .Where(em => em.MeasurementPoint.ConsumptionUnitID == id)
                .Select(em => em.ToDTO())
                .ToListAsync();
        }

        [HttpGet("{id}/current-transformers")]
        public async Task<IEnumerable<TransformerDTO>> GetCurrentTransformers(int id)
        {
            return await dbContext.CurrentTransformers
                .Where(em => em.MeasurementPoint.ConsumptionUnitID == id)
                .Select(em => em.ToDTO())
                .ToListAsync();
        }

        [HttpGet("{id}/voltage-transformers")]
        public async Task<IEnumerable<TransformerDTO>> GetVoltageTransformers(int id)
        {
            return await dbContext.VoltageTransformers
                .Where(em => em.MeasurementPoint.ConsumptionUnitID == id)
                .Select(em => em.ToDTO())
                .ToListAsync();
        }

        [HttpGet("{id}/electricity-meters/expired")]
        public async Task<IEnumerable<ElectricityMeterDTO>> GetExpiredElectricityMeters(int id)
        {
            return await dbContext.ElectricityMeters
                .Where(em => em.MeasurementPoint.ConsumptionUnitID == id && em.ExpiredAt < DateTime.Now)
                .Select(em => em.ToDTO())
                .ToListAsync();
        }

        [HttpGet("{id}/current-transformers/expired")]
        public async Task<IEnumerable<TransformerDTO>> GetExpiredCurrentTransformers(int id)
        {
            return await dbContext.CurrentTransformers
                .Where(em => em.MeasurementPoint.ConsumptionUnitID == id && em.ExpiredAt < DateTime.Now)
                .Select(em => em.ToDTO())
                .ToListAsync();
        }

        [HttpGet("{id}/voltage-transformers/expired")]
        public async Task<IEnumerable<TransformerDTO>> GetExpiredVoltageTransformers(int id)
        {
            return await dbContext.VoltageTransformers
                .Where(em => em.MeasurementPoint.ConsumptionUnitID == id && em.ExpiredAt < DateTime.Now)
                .Select(em => em.ToDTO())
                .ToListAsync();
        }
    }
}
