using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerDetails.Model
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class webapiController : ControllerBase
    {
        // GET: api/<webapiController>
        [HttpGet]
        public string Get()
        {
            Dbhandle db = new Dbhandle();
            return db.viewcustomer();
        }
        // POST api/<webapiController>
        [HttpPost]
        [Route("register")]
        public void Post(User c)
        {
            Dbhandle db = new Dbhandle();
            db.addcustomer(c);
            return;
        }
        // PUT api/<webapiController>/5
        [HttpPut]
        public void Put(User c)
        {
            Dbhandle db = new Dbhandle();
            db.updatecustomer(c);
            return;
        }
        // DELETE api/<CustomerAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Dbhandle db = new Dbhandle();
            db.DeleteCus(id);
            return;
        }
        [Route("getrecord")]
        public User Get(int CustomerID)
        {
            Dbhandle db = new Dbhandle();
            User cus = db.getcusonID(CustomerID);
            return cus;
        }
    }
}


