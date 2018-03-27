using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyOwinWebApi.Core.MyController
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public List<int> ShowNumberList()
        {
            return new List<int>() { 1, 2, 3 };
        }
    }
}
