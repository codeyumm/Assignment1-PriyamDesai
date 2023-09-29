using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_PriyamDesai.Controllers
{
    public class HostingCostController : ApiController
    {
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
