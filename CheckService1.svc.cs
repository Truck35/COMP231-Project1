/******************************************************************************************
 *                                                                                        *
 *     File: WCF Service                                                                  *
 *  Student: Kevin Haynes                                                                 *
 * Student#: 820076743                                                                    * 
 *  Course#: COMP231-061                                                                  * 
 *                                                                                        *
 * ****************************************************************************************/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TermsAndConditions;

namespace CheckCashingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CheckCashingService : ICheckCashingService
    {
        string answer = "";
        string accountInfo;
        Terms terms = new Terms();

        //gets users login info
        public string getLogIn(string account, string password)
        {
            return accountInfo;
        }//end getLogIn method

        //gets acceptance of Terms & Conditions
        public string getTermsAndConditions(bool value)
        {
            if (value == true)
            {
                answer = terms.getTermsAndAgreements(value);
                return answer;
            }
            else 
            {
                answer = "You must accept the Terms and Agreement befor you can use this application.";
                return answer;
            }
        }//end getTermsAndConditions method
    }
}
