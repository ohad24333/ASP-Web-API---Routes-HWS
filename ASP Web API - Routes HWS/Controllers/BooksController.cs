using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Web_API___Routes_HWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(5)}")]
        public  string GetMoreThenFive(int id)
        {
            return "Id More Then 5";
        }

        [Route("{id:regex((zoom|boom))}")]
        public string GetZoomOrBoom(string id)
        {
            return id;
        }
    }
}
