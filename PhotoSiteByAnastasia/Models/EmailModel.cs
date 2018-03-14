using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSiteByAnastasia.Models
{
    public class EmailModel
    {
        public string Subject { get; set; }

        public string From = "alender07@yandex.ru";

        public string To = "alender07@yandex.ru";

        public string Body { get; set; }
    }
}