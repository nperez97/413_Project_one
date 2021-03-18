using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Project_one.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookingDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookingDBContext>();



            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Groups.Any())
            {
                context.Groups.AddRange(
                    new Group
                    {
                        GroupName = "Layton 5th Ward",
                        GroupSize = 50,
                        GroupContactEmailAddress = "fake1@gmail.com",
                        GroupContactPhoneNumber = "123-123-1234",
                        GroupAppointmentID = 1
                    },
                    new Group
                    {
                        GroupName = "Layton 3rd Ward",
                        GroupSize = 45,
                        GroupContactEmailAddress = "fake2@gmail.com",
                        GroupContactPhoneNumber = "123-123-1235",
                        GroupAppointmentID = 2
                    },
                    new Group
                    {
                        GroupName = "Ogden YSA 2nd Ward",
                        GroupSize = 22,
                        GroupContactEmailAddress = "fake4@gmail.com",
                        GroupContactPhoneNumber = "123-123-1235",
                        GroupAppointmentID = 3
                    });

                    context.SaveChanges();
            }


            if (!context.Appointments.Any())
            {
                context.Appointments.AddRange(
                    // 3/18
                    new AppointmentModel
                    {
                        AppointmentStartTime = new DateTime(2021, 3, 18, 8, 0, 0),
                        Booked = true,
                    },
                    new AppointmentModel
                    {
                        AppointmentStartTime = new DateTime(2021, 3, 18, 9, 0, 0),
                        Booked = true,
                    },
                    new AppointmentModel
                    {
                        AppointmentStartTime = new DateTime(2021, 3, 18, 10, 0, 0),
                        Booked = true,
                    });
                context.SaveChanges();
            }
        }
        
    }
}