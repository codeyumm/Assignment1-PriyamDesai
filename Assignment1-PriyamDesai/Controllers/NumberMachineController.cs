using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_PriyamDesai.Controllers
{
    public class NumberMachineController : ApiController
    {
        public String[] get(int id)
        {
            // used four different maths operator
            int addTwo = id + 2;
            int subTwo = id - 2;
            int mulTwo = id * 2;
            double divsionTwo = id / 2;

            return new string[] {"Two added to " + id + " : " + addTwo,
                " Two substracted from " + id + " : " + subTwo, 
                "Two multiplicate to " + id + " : " + mulTwo, 
                id + " divided by Two: " + divsionTwo};
        }
    }
}
