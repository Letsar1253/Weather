namespace Common.Data.Models
{
    public class Weather
    {
        /// <summary>
        /// Направление ветра
        /// </summary>
        public double? WindDirection { get; set; }

        /// <summary>
        /// Основное направление ветра
        /// </summary>
        public string? CardinalWindDirection { get; set; }

        /// <summary>
        /// Скорость ветра
        /// </summary>
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Давление
        /// </summary>
        public double? Pressure { get; set; }

        /// <summary>
        /// Относительная влажностьЫ
        /// </summary>
        public double? RelativeHumidity { get; set; }

        /// <summary>
        /// Осадки
        /// </summary>
        public double? Precipitation { get; set; }

        /// <summary>
        /// Снегопад
        /// </summary>
        public double? Snowfall { get; set; }

        /// <summary>
        /// Облочность
        /// </summary>
        public double? CloudCover { get; set; }
    }
}
