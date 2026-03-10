using PersonalInfoManagement.Models.DbModels;
using PersonalInfoManagement.Models.dbContextClass;
using System;
using System.Linq;

namespace PersonalInfoManagement.Models.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            
            context.Database.EnsureCreated();

           
            if (context.PersonalInfos.Any())
                return;

            var rnd = new Random();

            string[] firstNames = { "Rahim", "Karim", "Hasan", "Rafi", "Sajid", "Nayeem", "Tanvir", "Fahim", "Sabbir", "Jahid" };
            string[] lastNames = { "Ahmed", "Khan", "Hossain", "Rahman", "Islam", "Chowdhury", "Sarker" };
            string[] genders = { "Male", "Female" };
            string[] cities = { "Dhaka", "Chittagong", "Khulna", "Rajshahi", "Sylhet" };

            for (int i = 1; i <= 1000; i++)
            {
                var first = firstNames[rnd.Next(firstNames.Length)];
                var last = lastNames[rnd.Next(lastNames.Length)];
                var gender = genders[rnd.Next(genders.Length)];
                var city = cities[rnd.Next(cities.Length)];

                context.PersonalInfos.Add(new PersonalInfo
                {
                    FirstName = first,
                    LastName = last,
                    Email = $"{first.ToLower()}.{last.ToLower()}{i}@mail.com",
                    PhoneNumber = "017" + rnd.Next(10000000, 100000000), 
                    Gender = gender,
                    Address = city,
                    Nationality = "Bangladeshi",
                    DateOfBirth = DateTime.Now.AddYears(-rnd.Next(18, 61)), 
                    CreatedDate = DateTime.Now
                });
            }

            context.SaveChanges();
        }
    }
}