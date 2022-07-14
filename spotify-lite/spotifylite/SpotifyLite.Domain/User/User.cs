
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

        public Guid Id { get; set; }

        public String Name { get; set; }
        public String NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Photo { get; set; }
        public CPF CPF { get; set; }
        public Email Email { get; set; }
        public String Country { get; set; }
        public String Gender { get; set; }
        public virtual Password Password { get; set; }
        public virtual IList<UserFavoriteMusic> FavoriteMusics { get; set; }

        public void Validate() => new UserValidator().ValidateAndThrow(this);
    }
}