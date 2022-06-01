using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.User.ValueObject
{
    public class Email
    {
        public Email(string email)
        {
            ArgumentNullException.IfNull(email, nameof(email))
            Value = email;
        }

        public string Value { get; set; }
    }
}