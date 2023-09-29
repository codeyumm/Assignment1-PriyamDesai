using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_PriyamDesai.Controllers
{
    public class SquareController : ApiController
    {
        // api/Square/2
        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
