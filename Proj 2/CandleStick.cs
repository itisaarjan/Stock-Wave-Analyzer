/*
Name: Arjan Subedi
Unumber: U81857374
*/

using System;
using System.Globalization;

namespace Project_2
{
    /// <summary>
    /// Holds date, open, high, low, close, and volume for a single candle.
    /// </summary>
    public class CandleStick
    {
        public DateTime Date { get; protected set; }
        public decimal Open { get; protected set; }
        public decimal High { get; protected set; }
        public decimal Low { get; protected set; }
        public decimal Close { get; protected set; }
        public long Volume { get; protected set; }

        /// <summary>
        /// Parses a CSV line (Date,Open,High,Low,Close,Volume).
        /// </summary>
        public CandleStick(string csvLine)
        {
            if (string.IsNullOrWhiteSpace(csvLine))
                throw new FormatException("Empty or null CSV line.");

            csvLine = csvLine.Replace("\"", "");
            string[] fields = csvLine.Split(',');
            if (fields.Length != 6)
            {
                throw new FormatException(
                    $"Line not valid. Expected 6 fields: {csvLine}"
                );
            }

            try
            {
                Date = DateTime.ParseExact(fields[0].Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                Open = decimal.Parse(fields[1], CultureInfo.InvariantCulture);
                High = decimal.Parse(fields[2], CultureInfo.InvariantCulture);
                Low = decimal.Parse(fields[3], CultureInfo.InvariantCulture);
                Close = decimal.Parse(fields[4], CultureInfo.InvariantCulture);
                Volume = long.Parse(fields[5], CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw new FormatException($"Parse fail: '{csvLine}' {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Protected empty constructor for inheritance or serialization.
        /// </summary>
        protected CandleStick()
        {
            Date = DateTime.MinValue;
        }
    }
}
