using System;
using System.Collections.Generic;
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
                                            VerificationDate = new DateTime(2021, 11, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType1,
                                            TransformationRatio = 1.12,
                                            VerificationDate = new DateTime(2021, 11, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType1,
                                            TransformationRatio = 1.13,
                                            VerificationDate = new DateTime(2021, 11, 3)
                                        }
                                    },
                                    new MeasurementPoint()
                                    {
                                        Name = "НТИЭ 1.2",
                                        ElectricityMeter = new ElectricityMeter()
                                        {
                                            Type = ElectricityMeterType.MeterType1,
                                            VerificationDate = new DateTime(2022, 12, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType2,
                                            TransformationRatio = 1.22,
                                            VerificationDate = new DateTime(2022, 12, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType2,
                                            TransformationRatio = 1.23,
                                            VerificationDate = new DateTime(2022, 12, 3)
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
                                            VerificationDate = new DateTime(2021, 11, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType1,
                                            TransformationRatio = 2.12,
                                            VerificationDate = new DateTime(2021, 11, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType1,
                                            TransformationRatio = 2.13,
                                            VerificationDate = new DateTime(2021, 11, 3)
                                        }
                                    },
                                    new MeasurementPoint()
                                    {
                                        Name = "СТИЭ 2.2",
                                        ElectricityMeter = new ElectricityMeter()
                                        {
                                            Type = ElectricityMeterType.MeterType1,
                                            VerificationDate = new DateTime(2022, 12, 1)
                                        },
                                        CurrentTransformer = new CurrentTransformer()
                                        {
                                            Type = CurrentTransformerType.CurrentTransformerType2,
                                            TransformationRatio = 2.22,
                                            VerificationDate = new DateTime(2022, 12, 2)
                                        },
                                        VoltageTransformer = new VoltageTransformer()
                                        {
                                            Type = VoltageTransformerType.VoltageTransformerType2,
                                            TransformationRatio = 2.23,
                                            VerificationDate = new DateTime(2022, 12, 3)
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            dbContext.ParentOrganizations.Add(parentOrganization);

            var cu1 = parentOrganization.ChildOrganizations[0].ConsumptionUnits[0];
            var mp11 = cu1.MeasurementPoints[0];
            var mp12 = cu1.MeasurementPoints[1];
            var ad11 = cu1.SupplyPoints[0].AccountingDevice;
            var ad12 = cu1.SupplyPoints[1].AccountingDevice;

            var cu2 = parentOrganization.ChildOrganizations[1].ConsumptionUnits[0];
            var mp21 = cu2.MeasurementPoints[0];
            var mp22 = cu2.MeasurementPoints[1];
            var ad21 = cu2.SupplyPoints[0].AccountingDevice;
            var ad22 = cu2.SupplyPoints[1].AccountingDevice;

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
