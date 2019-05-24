using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmolPaws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmolPaws.Data
{
    public static class DbInitializer
    {
        public static void InitializeDb(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
                
                if (context.Users.Any() == false)
                {
                    context.Users.AddRange(
                        new User()
                        {
                            FirstName = "Mehmet",
                            LastName = "Deveci",
                            UserName = "mbd",
                            EMail = "mb@gmail.com",
                            Password = "1234",
                            IsAdmin = false
                        },
                        new User()
                        {
                            FirstName = "Esra",
                            LastName = "Tarakci",
                            UserName = "esra",
                            EMail = "et@gmail.com",
                            Password = "1234",
                            IsAdmin = true
                        },
                        new User()
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            UserName = "jdoe",
                            EMail = "john@gmail.com",
                            Password = "1a234",
                            IsAdmin = false
                        });

                    context.SaveChanges();
                }

                if (context.Animals.Any() == false)
                {
                    User u = context.Users.First();
                    context.Animals.AddRange(
                        new Animal()
                        {
                            Name = "Kali",
                            Desc = "He is infected",
                            DonateNeeded = 25,
                            CurrentMoney = 0,
                            ImgPath = "AnimalImages/77b93805-fcbb-4702-8cb6-8d6d78856f43.png",
                            Datetime = DateTime.Now,
                            UserId = u.UserId
                        },
                        new Animal()
                        {
                            Name = "Dafi",
                            Desc = "He has to got into a surgery",
                            DonateNeeded = 150,
                            CurrentMoney = 0,
                            ImgPath = "AnimalImages/e7c9f8a7-791a-40dd-9ce6-40110ee2d476.jpg",
                            Datetime = DateTime.Now,
                            UserId = u.UserId
                        },
                        new Animal()
                        {
                            Name = "Lila",
                            Desc = "I need to buy her a medicine",
                            DonateNeeded = 10,
                            CurrentMoney = 0,
                            ImgPath = "AnimalImages/43600760-19b2-4fdd-a04e-f52eccc66efb.jpg",
                            Datetime = DateTime.Now,
                            UserId = u.UserId
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
}
    

