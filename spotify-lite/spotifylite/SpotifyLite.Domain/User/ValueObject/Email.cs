namespace SpotifyLite.Domain.User.ValueObject
{
    public class Email
    {
        public Email(string email)
        {
<<<<<<< HEAD
            ArgumentNullException.IfNull(email, nameof(email))
            Value = email;
        }

        public string Value { get; set; }
=======
            ArgumentNullException.ThrowIfNull(email, nameof(email));
            Value = email;
        }

        public string Value { get; private set; }
>>>>>>> b13ba2e... Modelagem inicial do dominio da solucao concluida
    }
}