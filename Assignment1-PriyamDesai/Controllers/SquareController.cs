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
        /// <summary>
        /// it takes one integer and returns a sqaure of it
        /// </summary>
        /// <param name="id">any integer</param>
        /// <returns>http://localhost:56522/api/square/1 -> <int>1</int> </returns>
        /// <returns>http://localhost:56522/api/square/4 -> <int>16</int> </returns>
        /// <returns>http://localhost:56522/api/square/2 -> <int>4</int> </returns>
        // api/Square/2
        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
