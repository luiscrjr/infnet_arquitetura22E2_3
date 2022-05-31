namespace SpotifyLite.Domain.Album.ValueObject
{
    public class Duration
    {
        public Duration(decimal inSeconds)
        {
            TotalInSeconds = inSeconds;
        }

        public decimal TotalInSeconds { get; private set; }

        private decimal PartInHours => Math.Floor(TotalInSeconds / 3600);

        private decimal PartInMinutes => Math.Floor(TotalInSeconds - (PartInHours * 3600) / 60);

        private decimal PartInSeconds => TotalInSeconds - (PartInHours * 3600) - (PartInMinutes * 60);

        public string InHoursMinutesAndSeconds => FormatInHoursMinutesAndSeconds();

        private string FormatInHoursMinutesAndSeconds()
        {
            return $"{PadLeftWithZerosForTwoCharsLength(PartInHours)}:" +
                $"{PadLeftWithZerosForTwoCharsLength(PartInMinutes)}:" +
                $"{PadLeftWithZerosForTwoCharsLength(PartInSeconds)}";
        }

        private static string PadLeftWithZerosForTwoCharsLength(decimal durationPart)
        {
            return durationPart.ToString().PadLeft(2, '0');
        }
    }
}