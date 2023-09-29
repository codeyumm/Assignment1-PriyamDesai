using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_PriyamDesai.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// this api return cost of hosting according to days
        /// </summary>
        /// <param name="id">numnber of days</param>
        /// <returns>http://localhost:56522/api/hostingCost/14 -> <ArrayOfstring>
        ///                                                       <string>2 fortnights at $5.50/FN = $11 CAD</string>
        ///                                                      <string>HST 13% = $1.43 CAD</string>
        ///                                                      <string>Total = $12.43 CAD</string>
        ///                                                      </ArrayOfstring>
        ///</returns>
        /// <returns>http://localhost:56522/api/hostingCost/0 -> <ArrayOfstring>
        ///                                                       <string>1 fortnights at $5.50/FN = $5.5 CAD</string>
        ///                                                      <string>HST 13% = $0.72 CAD</string>
        ///                                                      <string>Total = $6.22 CAD</string>
        ///                                                      </ArrayOfstring>
        ///</returns>
        /// <returns>http://localhost:56522/api/hostingCost/36 -> <ArrayOfstring>
        ///                                                       <string>3 fortnights at $5.50/FN = $16.5 CAD</string>
        ///                                                      <string>HST 13% = $2.14 CAD</string>
        ///                                                      <string>Total = $18.64 CAD</string>
        ///                                                      </ArrayOfstring>
        ///</returns>
        ///


        public String[] Get(int id)
        {
            //VARIABLES
            int noOfFortnight;
            int HST = 13; // to store the HST which is fixed
            double totalCost;
            double HSTcost;
            double amountWithHST;

            String fortnightCostMessage = " fortnights at $5.50/FN = $";
            String hstCostMessage = "HST 13% = $";
            String totalMessage = "Total = $";
            
            // used Math.celling() to round up the number of fortnight
            // as celing() method only works with double datatype I converted that into double
            // after that converted double into int to get the number of fortnight
            // doing id+1 because we are treating 0 as 1 fortnight
            noOfFortnight = (int)Math.Ceiling((double)(id+1) / 14);
            
           
            // the total amount of fortnight
            totalCost = noOfFortnight * 5.50;

            // total HST amount
            HSTcost = Math.Round((totalCost * HST) / 100, 2);

            // total amount with HST
            amountWithHST = Math.Round(HSTcost + totalCost, 2);

            //adding values in message
            fortnightCostMessage = noOfFortnight + fortnightCostMessage + totalCost + " CAD";

            hstCostMessage += HSTcost + " CAD";
            totalMessage += amountWithHST + " CAD";

            return new string[] { fortnightCostMessage, hstCostMessage, totalMessage };
  
        }
    }
}
