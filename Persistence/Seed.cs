using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence {
    public class Seed {
        public async static void SeedData (DataContext context, UserManager<AppUser> userManager) {
            if (!userManager.Users.Any ()) {
                var users = new List<AppUser> {
                    new AppUser {
                    DisplayName = "Bob",
                    UserName = "bob",
                    Email = "bob@test.com"
                    },
                    new AppUser {
                    DisplayName = "Daniel",
                    UserName = "daniel",
                    Email = "daniel@test.com"
                    },
                    new AppUser {
                    DisplayName = "Test",
                    UserName = "test",
                    Email = "test@test.com"
                    }
                };
                foreach (var user in users) {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }
            if (!context.Activities.Any ()) {
                var activities = new List<Domain.Activity> {
                    new Domain.Activity {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths (-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    },
                    new Domain.Activity {
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths (-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths (1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths (2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths (3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths (4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths (5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths (6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths (7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                    },
                    new Domain.Activity {
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths (8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                    }

                };

                context.Activities.AddRange (activities);
                context.SaveChanges ();
            }
        }

    }
}