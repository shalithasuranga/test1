using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            string file = "/storage/test.txt";
            try
            {
                System.IO.File.WriteAllText(file, DateTime.Now.ToString());
            }
            catch( Exception e)
            {
                return e.Message;
            }
            return "written";
        }
        // GET api/values
        [HttpGet("get")]
        public ActionResult<string> Read()
        {
            string file = "/storage/test.txt";
            try
            {
                return System.IO.File.ReadAllText(file);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


    }
}
