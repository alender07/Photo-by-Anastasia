using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoSiteByAnastasia.Models;
using ActionMailer.Net.Mvc;

namespace PhotoSiteByAnastasia.Controllers
{
    public class EmailController : MailerBase
    {
             

        public EmailResult SendEmail(EmailModel model)
        {
            To.Add(model.To);

            From = model.From;

            Subject = model.Subject;

            return Email("SendEmail", model);
        }

        
    }
}