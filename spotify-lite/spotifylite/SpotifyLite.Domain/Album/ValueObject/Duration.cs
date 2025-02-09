﻿namespace SpotifyLite.Domain.Album.ValueObject
{
    public class Duration
    {
        public Duration()
        {

        }

        public Duration(decimal valor)
        {
            this.Value = valor;
        }

        public Decimal Value { get; set; }

        public string FormatValue => Format(this.Value);

        private string Format(decimal value)
        {
            var hours = Math.Floor(value / 3600);
            var duration = value % 3600;

            var minutes = Math.Floor(duration / 60);

            if (hours > 0)
            {
                return $"{hours.ToString().PadLeft(2, '0')} hr {minutes.ToString().PadLeft(2, '0')} min";
            }

            return $"{minutes.ToString().PadLeft(2, '0')} min";
        }

        public override string ToString()
        {
            return FormatValue;
        }


    }
}
