﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using TractorSpecs.Core.Interfaces;
using TractorSpecs.Core.Objects;

namespace TractorSpecs.Controllers
{
    [RoutePrefix("api/email")]
    public class EmailController : ApiController
    {
        private ISettingService _settingService;

        public EmailController(Core.Interfaces.ISettingService settingService)
        {
            _settingService = settingService;
        }

        [Route("sendMessage")]
        [HttpPost]
        public IHttpActionResult SendMessage(EmailInformation emailInformation)
        {
            using (MailMessage message = new MailMessage())
            {
                var to = _settingService.GetEnvironmentSettingBySettingKey("to");

                message.To.Add(new MailAddress(to.settingValue));

                message.Subject = "EducaTours - Email from " + emailInformation.fullName;

                message.Body = @"Name: " + emailInformation.fullName + "\n Address: " + emailInformation.email +
                    "\n Message: " + emailInformation.message;

                using (SmtpClient client = new SmtpClient())
                {
                    client.Port = 25;

                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.UseDefaultCredentials = false;

                    client.Send(message);
                }
            }

            return Ok();
        }
    }
}
