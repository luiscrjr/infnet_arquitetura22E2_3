namespace SpotifyLite.Domain.Album.ValueObject
{
    public class Duration
    {
        public Duration()
        {
        }

        public Duration(decimal inSeconds)
        {
            InSeconds = inSeconds;
        }

        public decimal InSeconds { get; private set; }

        private decimal PartialInHours => Math.Floor(InSeconds / 3600);

        private decimal PartialInMinutes => Math.Floor((InSeconds - PartialInHours * 3600) / 60);

        private decimal PartialInSeconds => InSeconds - (PartialInHours * 3600) - (PartialInMinutes * 60);

            var minutes = Math.Floor(duration / 60);

            if (hours > 0)
            {
                return $"{hours.ToString().PadLeft(2, '0')} hr {minutes.ToString().PadLeft(2, '0')} min";
            }

            return $"{minutes.ToString().PadLeft(2, '0')} min";
        }

        private static string PadLeftWithZerosForTwoCharsLength(decimal durationPart)
        {
            return Math.Truncate(durationPart).ToString().PadLeft(2, '0');
        }
    }
}