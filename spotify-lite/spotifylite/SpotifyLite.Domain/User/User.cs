
using FluentValidation;
using SpotifyLite.Domain.User.Rules;
using SpotifyLite.Domain.User.ValueObject;

namespace SpotifyLite.Domain.User
{
    public class User
    {
        public User()
        {
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Photo { get; private set; }
        public CPF CPF { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public virtual ICollection<UserFavoriteSong> FavoriteSongs { get; private set; }

        public void Validate() => new UserValidator().ValidateAndThrow(this);
    }
}
