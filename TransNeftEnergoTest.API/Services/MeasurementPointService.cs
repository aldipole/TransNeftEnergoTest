using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;
using TransNeftEnergoTest.DAL;
using TransNeftEnergoTest.DAL.Models;

namespace TransNeftEnergoTest.API.Services
{
    public class MeasurementPointService
    {
        private readonly DatabaseContext dbContext;

        public MeasurementPointService(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<MeasurementPointDTO>> GetMeasurementPoints()
        {
            return await dbContext.MeasurementPoints
                .Include(mp => mp.ElectricityMeter)
                .Include(mp => mp.CurrentTransformer)
                .Include(mp => mp.VoltageTransformer)
                .Select(mp => mp.ToDTO())
                .ToListAsync();
        }

        public async Task<MeasurementPointDTO> Add(MeasurementPointDTO dto)
        {
            if (dto == null) return null;
            var mp = new MeasurementPoint(dto);
            dbContext.MeasurementPoints.Add(mp);
            int i = await dbContext.SaveChangesAsync();
            return mp.ToDTO();
        }
    }
}
