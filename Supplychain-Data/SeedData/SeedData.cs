﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Supplychain_Data.Models;
using Supplychain_Data.SystemContext;

namespace Supplychain_Data.SeedData
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SystemDbContext>();

                context.Database.EnsureCreated();

                if (!context.Warehouse.Any())
                {
                    context.Warehouse.AddRange(new List<Warehouse>
                    {
                        new Warehouse
                        {
                            Email = "ahmed@gmail.com",
                            Location = "Cairo",
                            Name = "Warehouse1",
                        },
                        new Warehouse
                        {
                            Email = "Warehouse2@gmail.com",
                            Location = "Cairo",
                            Name = "Warehouse2",
                        },
                        new Warehouse
                        {
                            Email = "ahmed@gmail.com",
                            Location = "Cairo",
                            Name = "Warehouse3",
                        },
                        new Warehouse
                        {
                            Email = "ahmed@gmail.com",
                            Location = "Cairo",
                            Name = "Warehouse4",
                        }
                    });

                    context.SaveChanges();
                }

                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(new List<Employee>
                    {
                        new Employee
                        {
                            Name = "Name1",
                            Address = "Address1",
                            Phone = 0121512,
                            WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse1").Id
                        },
                        new Employee
                        {
                            Name = "Name2",
                            Address = "Address2",
                            Phone = 0121512,
                            WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse2").Id
                        },
                        new Employee
                        {
                            Name = "Name3",
                            Address = "Address3",
                            Phone = 0121512,
                            WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse3").Id
                        },
                        new Employee
                        {
                            Name = "Name4",
                            Address = "Address4",
                            Phone = 0121512,
                            WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse4").Id
                        },
                    });

                    context.SaveChanges();
                }

                if (!context.Items.Any())
                {
                    context.Items.AddRange(new List<Item>
                    {
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item1" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item2" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item3" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item4" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item5" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item6" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item7" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item8" },
                        new Item { Code = "ASJDJBB", Description = "Dummy", MeasuringUnit = "KM", Name = "Item9" },
                    });

                    context.SaveChanges();
                }

                if (!context.WarehouseItems.Any())
                {
                    context.WarehouseItems.AddRange(new List<WarehouseItem>
                    {
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse1").Id, ItemId = context.Items.First(i => i.Name == "Item1").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse1").Id, ItemId = context.Items.First(i => i.Name == "Item2").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse1").Id, ItemId = context.Items.First(i => i.Name == "Item3").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse1").Id, ItemId = context.Items.First(i => i.Name == "Item4").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse2").Id, ItemId = context.Items.First(i => i.Name == "Item1").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse2").Id, ItemId = context.Items.First(i => i.Name == "Item2").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse2").Id, ItemId = context.Items.First(i => i.Name == "Item3").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse2").Id, ItemId = context.Items.First(i => i.Name == "Item4").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse3").Id, ItemId = context.Items.First(i => i.Name == "Item1").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse3").Id, ItemId = context.Items.First(i => i.Name == "Item2").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse3").Id, ItemId = context.Items.First(i => i.Name == "Item3").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse3").Id, ItemId = context.Items.First(i => i.Name == "Item4").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse4").Id, ItemId = context.Items.First(i => i.Name == "Item1").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse4").Id, ItemId = context.Items.First(i => i.Name == "Item2").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse4").Id, ItemId = context.Items.First(i => i.Name == "Item3").Id },
                        new WarehouseItem { WarehouseId = context.Warehouse.First(w => w.Name == "Warehouse4").Id, ItemId = context.Items.First(i => i.Name == "Item4").Id },
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}