namespace Cocomo.First.Average
{
    /// <summary>
    /// Class: <br/>
    /// RTF <br/>
    /// РТФ
    /// </summary>
    public class СriterionDictionary
    {
        /// <summary>
        /// Property: <br/>
        /// Criterion coefficient dictionary property <br/>
        /// Свойство словаря критериейв
        /// </summary>
        public System.Collections.Generic.Dictionary<Criterion, СriterionRatingAndValue> Rating { get; init; }
        public СriterionDictionary(
            Ratings rsr = Ratings.Nominal,
            Ratings sad = Ratings.Nominal,
            Ratings cop = Ratings.Nominal,
            Ratings rpc = Ratings.Nominal,
            Ratings mcs = Ratings.Nominal,
            Ratings vvm = Ratings.Nominal,
            Ratings rtt = Ratings.Nominal,
            Ratings acy = Ratings.Nominal,
            Ratings aee = Ratings.Nominal,
            Ratings sec = Ratings.Nominal,
            Ratings vme = Ratings.Nominal,
            Ratings ple = Ratings.Nominal,
            Ratings ase = Ratings.Nominal,
            Ratings ust = Ratings.Nominal,
            Ratings rds = Ratings.Nominal
            )
        {
            Rating = new System.Collections.Generic.Dictionary<Criterion, СriterionRatingAndValue>
            {
                [Criterion.RSR] = new(new(
                    veryLow: 0.75f,
                    low: 0.88f,
                    nominal: 1f,
                    high: 1.15f,
                    veryHigh: 1.40f
                    ), rsr),
                [Criterion.SAD] = new(new(
                    low: 0.94f,
                    nominal: 1f,
                    high: 1.08f,
                    veryHigh: 1.16f
                    ), sad),
                [Criterion.COP] = new(new(
                    veryLow: 0.7f,
                    low: 0.85f,
                    nominal: 1f,
                    high: 1.15f,
                    veryHigh: 1.30f,
                    extraHigh: 1.65f
                    ), cop),
                [Criterion.RPC] = new(new(
                    nominal: 1f,
                    high: 1.11f,
                    veryHigh: 1.30f,
                    extraHigh: 1.66f
                    ), rpc),
                [Criterion.MCS] = new(new(
                    nominal: 1f,
                    high: 1.06f,
                    veryHigh: 1.21f,
                    extraHigh: 1.56f
                    ), mcs),
                [Criterion.VVM] = new(new(
                    low: 0.87f,
                    nominal: 1f,
                    high: 1.15f,
                    veryHigh: 1.30f
                    ), vvm),
                [Criterion.RTT] = new(new(
                    low: 0.87f,
                    nominal: 1f,
                    high: 1.07f,
                    veryHigh: 1.15f
                    ), rtt),
                [Criterion.ACY] = new(new(
                    veryLow: 1.46f,
                    low: 1.19f,
                    nominal: 1f,
                    high: 0.86f,
                    veryHigh: 0.71f
                    ), acy),
                [Criterion.AEE] = new(new(
                    veryLow: 1.29f,
                    low: 1.13f,
                    nominal: 1f,
                    high: 0.91f,
                    veryHigh: 0.82f
                    ), aee),
                [Criterion.SEC] = new(new(
                    veryLow: 1.42f,
                    low: 1.17f,
                    nominal: 1f,
                    high: 0.86f,
                    veryHigh: 0.70f
                    ), sec),
                [Criterion.VME] = new(new(
                    veryLow: 1.21f,
                    low: 1.10f,
                    nominal: 1f,
                    high: 0.90f
                    ), vme),
                [Criterion.PLE] = new(new(
                    veryLow: 1.14f,
                    low: 1.07f,
                    nominal: 1f,
                    high: 0.95f
                    ), ple),
                [Criterion.ASE] = new(new(
                    veryLow: 1.24f,
                    low: 1.10f,
                    nominal: 1f,
                    high: 0.91f,
                    veryHigh: 0.82f
                    ), ase),
                [Criterion.UST] = new(new(
                    veryLow: 1.24f,
                    low: 1.10f,
                    nominal: 1f,
                    high: 0.91f,
                    veryHigh: 0.83f
                    ), ust),
                [Criterion.RDS] = new(new(
                    veryLow: 1.23f,
                    low: 1.08f,
                    nominal: 1f,
                    high: 1.04f,
                    veryHigh: 1.10f
                    ), rds)
            };
        }

        public СriterionRatingAndValue RSR => Rating[Criterion.RSR];
        public СriterionRatingAndValue SAD => Rating[Criterion.SAD];
        public СriterionRatingAndValue COP => Rating[Criterion.COP];
        public СriterionRatingAndValue RPC => Rating[Criterion.RPC];
        public СriterionRatingAndValue MCS => Rating[Criterion.MCS];
        public СriterionRatingAndValue VVM => Rating[Criterion.VVM];
        public СriterionRatingAndValue RTT => Rating[Criterion.RTT];
        public СriterionRatingAndValue ACY => Rating[Criterion.ACY];
        public СriterionRatingAndValue AEE => Rating[Criterion.AEE];
        public СriterionRatingAndValue SEC => Rating[Criterion.SEC];
        public СriterionRatingAndValue VME => Rating[Criterion.VME];
        public СriterionRatingAndValue PLE => Rating[Criterion.PLE];
        public СriterionRatingAndValue ASE => Rating[Criterion.ASE];
        public СriterionRatingAndValue UST => Rating[Criterion.UST];
        public СriterionRatingAndValue RDS => Rating[Criterion.RDS];

    }
}
