namespace SpotifyLite.Domain.User.ValueObject
{
    public class Password
    {
        public Password()
        {
        }

        public Password(string password)
        {
            ArgumentNullException.ThrowIfNull(password, nameof(password));
            Value = password;
        }

        public string Value { get; private set; }
    }
}