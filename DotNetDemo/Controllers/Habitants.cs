using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace DotNetDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HabitantsController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Habitant> Get()
        {
            var habitants = getAllHabitantsasList();
            throw new NotImplementedException();
        }
        
        private List<Habitant> getAllHabitantsasList()
        {
            //var filePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory), @"/DataBase/Habitants.json");
            var filePath = Path.GetFullPath("DataBase/Habitants.json");
           var habitants = System.IO.File.ReadAllText(filePath);

           return JsonConvert.DeserializeObject<List<Habitant>>(habitants);

        }
    }


}
