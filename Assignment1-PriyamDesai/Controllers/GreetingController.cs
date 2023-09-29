using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_PriyamDesai.Controllers
{
    public class GreetingController : ApiController
    {

        public String Get(int id)
        {
            String result = "Greetings to " + id + " People!";
            return result;
        }

        // post
       public String Post()
        {
            String outputString = "Hello World!";
            return outputString;
        }
    }
}
