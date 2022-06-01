using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private decimal PartInMinutes
        {
            get
            {
                var remainingSeconds = TotalInSeconds - (PartInHours * 3600);
                return Math.Floor(remainingSeconds / 60);
            }
        }

        private decimal PartInSeconds => TotalInSeconds - (PartInHours * 3600) - (PartInMinutes * 60);

        public string InHoursMinutesAndSeconds => FormatInHoursMinutesAndSeconds();

        private string FormatInHoursMinutesAndSeconds()
        {
            return $"{PadLeftWithZerosUntilTwoDigitsLength(PartInHours)}:" +
                $"{PadLeftWithZerosUntilTwoDigitsLength(PartInMinutes)}:" +
                $"{PadLeftWithZerosUntilTwoDigitsLength(PartInSeconds)}";
        }

        private string PadLeftWithZerosUntilTwoDigitsLength(decimal durationPart)
        {
            return durationPart.ToString().PadLeft(2, '0');
        }

    }
}