namespace SpotifyLite.Domain.User.ValueObject
{
    public class Email
    {
        public Email(string email)
        {
            ArgumentNullException.ThrowIfNull(email, nameof(email));
            Value = email;
        }

        public string Value { get; private set; }
    }
}