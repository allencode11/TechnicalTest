using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalTest.DataAccess;
using TechnicalTest.DataAccess.Models;
using TechnicalTest.Models;

namespace TechnicalTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly ApplicationDbContext _Db;

        // to generate the id i will use base 16 numbers
        // the format from xxxxxxxx-xxxx-xxxx-xxxx-xxxx-xxxxxxxx
        // so the first and the last fragment should be a number betwenn 11111111 and ffffffff and the others between 1111 and ffff
        // to generate random numbers i will convert the number in base 10 and use Random class
        protected string IdGenerator()
        {
            Random r = new Random();

            int num = r.Next(1, 143136142);
            var Tempid = num + 286331153;
            string id = Convert.ToString(Tempid, 16) + "-";

            for (int i = 0; i < 4; i++)
            {
                int num2 = r.Next(4369, 65535);
                id += Convert.ToString(num2, 16) + "-";
            }

            num = r.Next(1, 143136142);
            id += Convert.ToString(Tempid, 16);

            return id;
        }
        public RegistrationController(ApplicationDbContext Db)
        {
            _Db = Db;
        }


        [HttpGet]
        public async Task<Registration> GetRegistration(string id)
        {
            if (_Db != null)
            {
                if (id != null)
                {
                    return await _Db.Registrations.FirstOrDefaultAsync(item => item.Id == id);
                }
                throw new ArgumentException("Parameter cannot be null", nameof(id));
            }

            throw new NullReferenceException("Database instance was null");
        }

        // add a registration to db
        [HttpPost]
        public async Task<string> AddRegistration(RegistrationRequest post)
        {
            if (_Db != null)
            {
                var newItem = new Registration
                {
                    Id = IdGenerator(),
                    Locale = post.Locale,
                    RegistrationDate = post.RegistrationDate,
                    Person = new Person
                    {
                        Address = post.Person.Address,
                        FirtName = post.Person.FirtName,
                        LastName = post.Person.LastName,
                        Email = post.Person.Email,

                    },
                    Organization = new Organization
                    {
                        Address = post.Organization.Address,
                        Name = post.Organization.Name,
                    },
                };

                await _Db.Registrations.AddAsync(newItem);
                await _Db.SaveChangesAsync();

                return newItem.Id;
            }

            throw new NullReferenceException("Database instance was null");
        }

        //delete a registration from db
        [HttpDelete]
        public async Task<string> DeleteRegistration(string id)
        {
            if (_Db != null)
            {
                //Find the registration
                var item = await _Db.Registrations.FirstOrDefaultAsync(x => x.Id == id);

                if (item != null)
                {
                    //Delete that post
                    _Db.Registrations.Remove(item);

                    await _Db.SaveChangesAsync();

                    return "Registration was deleted succesfully";
                }
                return "Registration was not found";
            }

            throw new NullReferenceException("Database instance was null");
        }

        [HttpPut]
        public async Task<Registration> UpdateRegistration(Registration item)
        {
            if (_Db != null)
            {
                // Update that post
                _Db.Registrations.Update(item);

                await _Db.SaveChangesAsync();

                return await _Db.Registrations.FirstOrDefaultAsync(reg => reg.Id == item.Id);
            }

            throw new NullReferenceException("Database instance was null");
        }
    }

}

