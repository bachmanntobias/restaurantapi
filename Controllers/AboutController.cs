using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        [Route("")]
        public String Phone()
        {
            return "017657733601";
        }

        [Route("[action]")]
        public String Address()
        {
            return "Grosswallstadt";
        }
    }
}