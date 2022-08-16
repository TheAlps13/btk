using System;

namespace template_design_method
{
    public abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        protected abstract int CalculateOverallScore(int score, int reduction);
        protected abstract int CalculateReduction(TimeSpan time);
        protected abstract int CalculateBaseScore(int hits);
    }
}
