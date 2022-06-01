<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.User.ValueObject
{
    public class Password
    {
        public Password()
        {

        }
        public Password(string value)
        {
            this.Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Value { get; set; }
=======
﻿namespace SpotifyLite.Domain.User.ValueObject
{
    public class Password
    {
        public Password(string password)
        {
            ArgumentNullException.ThrowIfNull(password, nameof(password));
            Value = password;
        }

        public string Value { get; private set; }
>>>>>>> b13ba2e... Modelagem inicial do dominio da solucao concluida
    }
}
