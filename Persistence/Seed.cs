using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Make = "BMW",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "1233211km",
                    Model = "7 series",
                    City = "London",
                },
                new Activity
                {
                    Make = "Mercedes Benz",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "10km",
                    Model = "S CLASS",
                    City = "Paris",
                },
                new Activity
                {
                    Make = "VW",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "00km",
                    Model = "GOLF 8",
                    City = "London",
                },
                new Activity
                {
                    Make = "VOLVO",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "1101km",
                    Model = "GT",
                    City = "London",
                },
                new Activity
                {
                    Make = "RENAULT",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "111122km",
                    Model = "SPIDER",
                    City = "London",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
} 