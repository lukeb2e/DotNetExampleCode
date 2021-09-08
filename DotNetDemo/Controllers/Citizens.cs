using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace DotNetDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitizenController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            //Todo Read json file and return a list of type citizen with the same properties as the json objects
            throw new NotImplementedException();
        }
        
    }


}
