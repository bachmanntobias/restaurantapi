using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace RestaurantAPI.Services
{
    public interface IGreeter
    {
        String GetMessageOfTheDay();
    }
    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
            public String GetMessageOfTheDay()
            {
                return _configuration["Greeting"];
            }
    }
}


