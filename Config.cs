using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Twilio.logic
{
   public static class Config
    {
        public static string accountid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        public static string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");




        //// Find your Account SID and Auth Token at twilio.com/console
        //// and set the environment variables. See http://twil.io/secure
        //string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        //string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

        //TwilioClient.Init(accountSid, authToken);

        //var message = MessageResource.Create(
        //    body: "This is the ship that made the Kessel Run in fourteen parsecs?",
        //    from: new Twilio.Types.PhoneNumber("+15017122661"),
        //    to: new Twilio.Types.PhoneNumber("+15558675310")
        //);

        //Console.WriteLine(message.Sid);

    }
}
