using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Twilio.Jwt.AccessToken;
using Microsoft.AspNetCore.Cors;

namespace TwilioBlazorPhonecalls.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration configuration;
        //private static readonly HttpClient httpClient = new HttpClient();

        public TokenController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        [EnableCors("BlazorClientPolicy")]
        public string Get()
        {
            string twilioAccountSid = configuration["TwilioAccountSid"];
            string twilioApiKey = configuration["TwilioApiKey"];
            string twilioApiSecret = configuration["TwilioApiSecret"];
            string twiMLApplicationSid = configuration["TwiMLApplicationSid"];

            var grants = new HashSet<IGrant>();
            // Create a Voice grant for this token
            grants.Add(new VoiceGrant
            {
                OutgoingApplicationSid = twiMLApplicationSid,
                IncomingAllow = true
            });

            // Create an Access Token generator
            var token = new Token(
                twilioAccountSid,
                twilioApiKey,
                twilioApiSecret,
                // identity will be used as the client name for incoming dials
                identity: "blazor_client",
                grants: grants
            );

            return token.ToJwt();
        }
    }
}
