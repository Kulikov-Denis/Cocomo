namespace Cocomo.First.Average
{
    /// <summary>
    /// Class: <br/>
    /// Сriterion RTF <br/>
    /// Критерий РТФ
    /// </summary>
    public record СriterionRatings
    {
        /// <summary>
        /// Property: <br/>
        /// Criterion coefficient dictionary property <br/>
        /// Свойство словаря коэффициентов критерия
        /// </summary>
        public System.Collections.Generic.Dictionary<Ratings, float?> Rating { get; init; }

        public СriterionRatings(float? veryLow = null, float? low = null, float? nominal = null, float? high = null, float? veryHigh = null, float? extraHigh = null) => Rating = new System.Collections.Generic.Dictionary<Ratings, float?>
        {
            [Ratings.VeryLow] = veryLow,
            [Ratings.Low] = low,
            [Ratings.Nominal] = nominal,
            [Ratings.High] = high,
            [Ratings.VeryHigh] = veryHigh,
            [Ratings.ExtraHigh] = extraHigh
        };

        public float? VeryLow => Rating[Ratings.VeryLow];
        public float? Low => Rating[Ratings.Low];
        public float? Nominal => Rating[Ratings.Nominal];
        public float? High => Rating[Ratings.High];
        public float? VeryHigh => Rating[Ratings.VeryHigh];
        public float? ExtraHigh => Rating[Ratings.ExtraHigh];
    }
}
