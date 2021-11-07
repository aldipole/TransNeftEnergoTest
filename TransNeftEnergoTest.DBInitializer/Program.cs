using System;
using System.Collections.Generic;
using System.Linq;
using TransNeftEnergoTest.DAL;
using TransNeftEnergoTest.DAL.Models;

namespace TransNeftEnergoTest.DBInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseContext dbContext = new DatabaseContext();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            ParentOrganization parentOrganization = new ParentOrganization()
            {
                Name = "Объединенная Трубопрокатная Корпорация",
                Address = "Москва, Россия",
                ChildOrganizations = new List<ChildOrganization>()
                {
                    new ChildOrganization()
                    {
                        Name = "Нижегородский трубопрокатный завод",
                        Address = "Нижний Новгород, Россия",
                        ConsumptionUnits = new List<ConsumptionUnit>()
                        {
                            new ConsumptionUnit()
                            {
                                Name = "Трубоспрямительный цех",
                                Address = "Нижний Новгород, Россия",
                                SupplyPoints = new List<SupplyPoint>()
                                {
                                    new SupplyPoint()
                                    {
                                        Name = "НТПЭ 1.1",
                                        MaxPower = 101,
                                        AccountingDevice = new AccountingDevice()
                                    },
                                    new SupplyPoint()
                                    {
                                        Name = "НТПЭ 1.2",
                                        MaxPower = 102,
                                        AccountingDevice = new AccountingDevice()
                                    }
                                },
                                MeasurementPoints = new List<MeasurementPoint>()
                                {
                                    new MeasurementPoint()
                                    {
                                        Name = "НТИЭ 1.1",
                                        ElectricityMeter = new ElectricityMeter()
                                        {
                                            Type = ElectricityMeterType.MeterType1,
                                            ExpiredAt = new DateTime(2021, 9, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType1,
                                            TransformationRatio = 1.12,
                                            ExpiredAt = new DateTime(2021, 9, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType1,
                                            TransformationRatio = 1.13,
                                            ExpiredAt = new DateTime(2021, 9, 3)
                                        }
                                    },
                                    new MeasurementPoint()
                                    {
                                        Name = "НТИЭ 1.2",
                                        ElectricityMeter = new ElectricityMeter()
                                        {
                                            Type = ElectricityMeterType.MeterType1,
                                            ExpiredAt = new DateTime(2022, 12, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType2,
                                            TransformationRatio = 1.22,
                                            ExpiredAt = new DateTime(2022, 12, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType2,
                                            TransformationRatio = 1.23,
                                            ExpiredAt = new DateTime(2022, 12, 3)
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new ChildOrganization()
                    {
                        Name = "Саратовский трубопрокатный завод",
                        Address = "Саратов, Россия",
                        ConsumptionUnits = new List<ConsumptionUnit>()
                        {
                            new ConsumptionUnit()
                            {
                                Name = "Трубоиискревительный цех",
                                Address = "Саратов, Россия",
                                SupplyPoints = new List<SupplyPoint>()
                                {
                                    new SupplyPoint()
                                    {
                                        Name = "СТПЭ 2.1",
                                        MaxPower = 101,
                                        AccountingDevice = new AccountingDevice()
                                    },
                                    new SupplyPoint()
                                    {
                                        Name = "СТПЭ 2.2",
                                        MaxPower = 102,
                                        AccountingDevice = new AccountingDevice()
                                    }
                                },
                                MeasurementPoints = new List<MeasurementPoint>()
                                {
                                    new MeasurementPoint()
                                    {
                                        Name = "СТИЭ 2.1",
                                        ElectricityMeter = new ElectricityMeter()
                                        {
                                            Type = ElectricityMeterType.MeterType1,
                                            ExpiredAt = new DateTime(2021, 9, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType1,
                                            TransformationRatio = 2.12,
                                            ExpiredAt = new DateTime(2021, 9, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType1,
                                            TransformationRatio = 2.13,
                                            ExpiredAt = new DateTime(2021, 9, 3)
                                        }
                                    },
                                    new MeasurementPoint()
                                    {
                                        Name = "СТИЭ 2.2",
                                        ElectricityMeter = new ElectricityMeter()
                                        {
                                            Type = ElectricityMeterType.MeterType1,
                                            ExpiredAt = new DateTime(2022, 12, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType2,
                                            TransformationRatio = 2.22,
                                            ExpiredAt = new DateTime(2022, 12, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType2,
                                            TransformationRatio = 2.23,
                                            ExpiredAt = new DateTime(2022, 12, 3)
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            dbContext.ParentOrganizations.Add(parentOrganization);

            var cu1 = parentOrganization.ChildOrganizations.First().ConsumptionUnits.First();
            var mp11 = cu1.MeasurementPoints.First();
            var mp12 = cu1.MeasurementPoints.Skip(1).First();
            var ad11 = cu1.SupplyPoints.First().AccountingDevice;
            var ad12 = cu1.SupplyPoints.Skip(1).First().AccountingDevice;

            var cu2 = parentOrganization.ChildOrganizations.Skip(1).First().ConsumptionUnits.First();
            var mp21 = cu2.MeasurementPoints.First();
            var mp22 = cu2.MeasurementPoints.Skip(1).First();
            var ad21 = cu2.SupplyPoints.First().AccountingDevice;
            var ad22 = cu2.SupplyPoints.Skip(1).First().AccountingDevice;

            dbContext.MeasurementPointToAccountingDevice.AddRange(new List<MeasurementPointToAccountingDevice>{
                new MeasurementPointToAccountingDevice()
                {
                    MeasurementPoint = mp11,
                    AccountingDevice = ad11,
                    From = new DateTime(2020, 1, 1),
                    To = new DateTime(2020, 12, 31)
                },
                new MeasurementPointToAccountingDevice()
                {
                    MeasurementPoint = mp12,
                    AccountingDevice = ad12,
                    From = new DateTime(2021, 1, 1),
                    To = new DateTime(2021, 12, 31)
                },
                new MeasurementPointToAccountingDevice()
                {
                    MeasurementPoint = mp21,
                    AccountingDevice = ad21,
                    From = new DateTime(2020, 1, 1),
                    To = new DateTime(2020, 12, 31)
                },
                new MeasurementPointToAccountingDevice()
                {
                    MeasurementPoint = mp22,
                    AccountingDevice = ad22,
                    From = new DateTime(2021, 1, 1),
                    To = new DateTime(2021, 12, 31)
                },
            });

            dbContext.SaveChanges();
        }
    }
}
