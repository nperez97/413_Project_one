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
                    // booked for seeding groups 
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 8, 0, 0), Booked = true },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 9, 0, 0), Booked = true },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 10, 0, 0), Booked = true },
                    // Hardcoded for seeding puposes
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 11, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 12, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 13, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 14, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 15, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 16, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 17, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 18, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 19, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 18, 20, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 8, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 9, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 10, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 11, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 12, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 13, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 14, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 15, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 16, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 17, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 18, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 19, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 19, 20, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 8, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 9, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 10, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 11, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 12, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 13, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 14, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 15, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 16, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 17, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 18, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 19, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 20, 20, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 8, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 9, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 10, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 11, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 12, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 13, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 14, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 15, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 16, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 17, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 18, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 19, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 21, 20, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 8, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 9, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 10, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 11, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 12, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 13, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 14, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 15, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 16, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 17, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 18, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 19, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 22, 20, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 8, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 9, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 10, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 11, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 12, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 13, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 14, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 15, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 16, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 17, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 18, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 19, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 23, 20, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 8, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 9, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 10, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 11, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 12, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 13, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 14, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 15, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 16, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 17, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 18, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 19, 0, 0), Booked = false },
                    new AppointmentModel { AppointmentStartTime = new DateTime(2021, 3, 24, 20, 0, 0), Booked = false }
                    );
                context.SaveChanges();
            }
        }
        
    }
}