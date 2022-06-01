namespace SpotifyLite.Domain.User.ValueObject
{
    public class CPF
    {
        public CPF(string cpf)
        {
            ArgumentNullException.ThrowIfNull(cpf, nameof(cpf));
            Value = FormatWithDigitsOnly(cpf);
        }

        public string Value { get; private set; }

        public string FormatWithPointsAndDots => FormatValueWithPointsAndDots();

        private string FormatWithDigitsOnly(string cpf) => cpf.Replace(".", "").Replace("-", "");
        private string FormatValueWithPointsAndDots() => Convert.ToInt64(Value).ToString(@"000\.000\.000\-00");
    }
}