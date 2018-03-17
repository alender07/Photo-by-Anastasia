using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhotoSiteByAnastasia.Models
{
    public class EmailModel
    {
        public string Subject { get; set; }

        public string Name { get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Неверный формат электронной почты")]
        public string Email { get; set; }

        public string From = "alender07@yandex.ru";

        public string To = "alender07@yandex.ru";

        public string Body { get; set; }
    }
}