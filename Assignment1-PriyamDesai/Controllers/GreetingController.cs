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
        /// <summary>
        /// Get method return a string message based on input integer
        /// </summary>
        /// 
        /// <param name="id">any integer</param>
        /// 
        /// <returns>http://localhost:56522/api/greeting/6 -> <string>Greetings to 6 People!</string> </returns>
        /// <returns>http://localhost:56522/api/greeting/16 -> <string>Greetings to 16 People!</string> </returns>
        /// <returns>http://localhost:56522/api/greeting/36 -> <string>Greetings to 36 People!</string> </returns>
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
