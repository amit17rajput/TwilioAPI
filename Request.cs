using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Twilio;
using Twilio.Base;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Api.V2010.Account.AvailablePhoneNumberCountry;

namespace Twilio.logic
{
   public class Request
    {
        //On live Server
        //string _accountSId = Environment.GetEnvironmentVariable("AC8809a2377cbaaa2ebc24e47f1e0a5d2e").ToString();
        //string _authToken = Environment.GetEnvironmentVariable("bc7a9de7d3b09e782a72a8ada4cb2287");

        //On local
        string _accountSId = "AC8809a2377cbaaa2ebc24e47f1e0a5d2e";
        string _authToken = "bc7a9de7d3b09e782a72a8ada4cb2287";


        public Request()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            TwilioClient.Init(_accountSId, _authToken);
        } 
        public MessageResource SendSMS(string Body,string ToMobileNumber)
        {

            MessageResource message = MessageResource.Create(
                body: Body,
                from: new Twilio.Types.PhoneNumber("+13025261515"),
                to: new Twilio.Types.PhoneNumber(ToMobileNumber)
           ); ;

            return message;

        }

        public AvailablePhoneNumberCountryResource FetchNumberBySpecificCountry(Country _country)
        {
            AvailablePhoneNumberCountryResource availablePhoneNumberCountry = AvailablePhoneNumberCountryResource.Fetch(pathCountryCode: _country.ToString());
            return availablePhoneNumberCountry;
        }
        public ResourceSet<LocalResource> FindAvailableLocalPhoneNumbersByAreaCode(CountryCode _code, Country _pathCountryCode,int _limit )
        {
            ResourceSet<LocalResource> _local = LocalResource.Read(areaCode:(int)_code, pathCountryCode:_pathCountryCode.ToString(), limit: _limit); 
            return _local; 
        }

        public IncomingPhoneNumberResource CreateIncomingPhoneNumber(string _PhoneNumber)
        {
            IncomingPhoneNumberResource _incomingPhoneNumber = IncomingPhoneNumberResource.Create(phoneNumber: new Twilio.Types.PhoneNumber("_PhoneNumber"));
            return _incomingPhoneNumber;
        } 
    }
}
