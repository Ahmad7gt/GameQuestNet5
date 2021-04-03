using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Models
{
    public class SendEmailModel
    {
        public string Email { get; set; }
        public string Message { get; set; }

        public SendEmailModel(string email, string message)
        {
            Email = email;
            Message = message;
        }
    }
}
