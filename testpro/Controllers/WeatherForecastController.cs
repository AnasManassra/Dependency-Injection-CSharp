using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;

namespace testpro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        IUser U = null;
         public WeatherForecastController(IUser U)
        {
            this.U = U;
        }
        [HttpGet]
        public List<User> Get()
        {
            return U.getall();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
           
            return U.get(id);
        }

       /* [HttpGet("{Names}")]
        public List<string> Get(string Names)
        {
            var b = Users.Select(item => item.name).ToList();
            return b;
        } //not working */

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           U.DeleteUser(id);
        }
        /*
        [HttpPut("{id}")]
        public void put(int id, [FromBody]User user)
        {
            var b = Users.FirstOrDefault(x => x.Id == id);
            b.DoB = user.DoB;
            b.email = user.email;
            b.Id = user.Id;
            b.name = user.name;
            b.phone = user.phone;
            
        }
        */
        [HttpPost]
        public void post([FromBody]User user)
        {
            U.AddUser(user);
        }

    }
}
