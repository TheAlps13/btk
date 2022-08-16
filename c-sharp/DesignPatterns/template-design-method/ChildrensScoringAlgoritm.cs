using System;

namespace template_design_method
{
    public class ChildrensScoringAlgoritm : ScoringAlgorithm
    {
        protected override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }

        protected override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        protected override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }
}
