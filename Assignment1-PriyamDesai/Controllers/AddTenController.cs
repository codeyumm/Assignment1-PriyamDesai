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
        /// <summary>
        /// this method return plus ten to the input number
        /// </summary>
        /// 
        /// <param name="id">Any Integer</param>
        /// 
        /// <returns> http://localhost:56522/api/AddTen/6 -> <int>16</int> </returns>
        /// <returns> http://localhost:56522/api/AddTen/50 -> <int>60</int> </returns>
        /// <returns> http://localhost:56522/api/AddTen/36 -> <int>46</int> </returns>


        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }
}
