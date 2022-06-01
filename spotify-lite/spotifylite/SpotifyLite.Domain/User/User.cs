<<<<<<< HEAD
﻿using FluentValidation;
using SpotifyLite.Domain.User.Rules;
using SpotifyLite.Domain.User.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using SpotifyLite.Domain.User.ValueObject;
>>>>>>> b13ba2e... Modelagem inicial do dominio da solucao concluida

namespace SpotifyLite.Domain.User
{
    public class User
    {
        public Guid Id { get; private set; }
<<<<<<< HEAD

        public String Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Photo { get; private set; }
        public CPF CPF { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public ICollection<UserFavoriteSong> FavoriteSongs { get; private set; }

        public void Validate() => new UserValidator().ValidateAndThrow(this);
=======
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Photo { get; set; }
        public CPF CPF { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public ICollection<UserFavoriteSong> FavoriteSongs { get; set; }
>>>>>>> b13ba2e... Modelagem inicial do dominio da solucao concluida
    }
}
