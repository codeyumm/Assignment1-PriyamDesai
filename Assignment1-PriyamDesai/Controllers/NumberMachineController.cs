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
        /// <summary>
        /// takes one int and performs four math operation on it and returns result
        /// </summary>
        /// <param name="id">any number</param>
        /// <returns>
        /// http://localhost:56522/api/numbermachine/36 -> <ArrayOfstring>
        ///                                                <string>Two added to 36 : 38</string>
        ///                                                <string> Two substracted from 36 : 34</string>
        ///                                                <string>Two multiplicate to 36 : 72</string>
        ///                                                <string>36 divided by Two: 18</string>
        ///                                                </ArrayOfstring>
        /// </returns>
        /// 
        /// <returns>
        /// http://localhost:56522/api/numbermachine/1 -> <ArrayOfstring>
        ///                                                <string>Two added to 1 : 3</string>
        ///                                                <string> Two substracted from 1 : -1</string>
        ///                                                <string>Two multiplicate to 1 : 2</string>
        ///                                                <string>1 divided by Two: 0</string>
        ///                                                </ArrayOfstring>
        /// </returns>
        /// 

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
