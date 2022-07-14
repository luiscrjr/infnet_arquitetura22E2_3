namespace SpotifyLite.Domain.User.ValueObject
{
    public class Email
    {
        public Email()
        {

        }

        public Email(string email)
        {
            this.Value = email ?? throw new ArgumentNullException(nameof(email));
        }

        public string Value { get; set; }
    }
}
