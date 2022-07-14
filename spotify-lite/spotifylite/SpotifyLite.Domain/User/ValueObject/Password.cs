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
    }
}
