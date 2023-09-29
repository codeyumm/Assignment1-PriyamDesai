using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_PriyamDesai.Controllers
{
    public class AddTenController : ApiController
    {
        //api/AddtoTen/{2} -> 12
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }
}
