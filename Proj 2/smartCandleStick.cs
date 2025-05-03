/*
Name: Arjan Subedi
Unumber: U81857374
*/
using System;

namespace Project_2
{
    /// <summary>
    /// Adds numeric convenience properties for range, shadows, etc. 
    /// </summary>
    public class SmartCandleStick : CandleStick
    {
        public decimal Range => High - Low;
        public decimal Body => Math.Abs(Open - Close);
        public decimal UpperShadow => High - Math.Max(Open, Close);
        public decimal LowerShadow => Math.Min(Open, Close) - Low;

        /// <summary>
        /// Builds SmartCandleStick directly from CSV.
        /// </summary>
        public SmartCandleStick(string csvLine) : base(csvLine)
        {
        }

        /// <summary>
        /// Builds SmartCandleStick by copying CandleStick fields.
        /// </summary>
        public SmartCandleStick(CandleStick cs) : base()
        {
            Date = cs.Date;
            Open = cs.Open;
            High = cs.High;
            Low = cs.Low;
            Close = cs.Close;
            Volume = cs.Volume;
        }
    }
}
