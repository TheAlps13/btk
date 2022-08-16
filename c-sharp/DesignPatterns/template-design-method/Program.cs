using System;

namespace template_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm mensAlgorithm = new MensScoringAlgorithm();
            Console.WriteLine($"Mens score : {mensAlgorithm.GenerateScore(12, TimeSpan.FromSeconds(100))}");
            ScoringAlgorithm womansAlgorithm = new WomansScoringAlgorithm();
            Console.WriteLine($"Womans score : {womansAlgorithm.GenerateScore(12, TimeSpan.FromSeconds(100))}");
            ScoringAlgorithm childrensAlgorithm = new ChildrensScoringAlgoritm();
            Console.WriteLine($"Childrens score : {childrensAlgorithm.GenerateScore(12, TimeSpan.FromSeconds(100))}");
        }
    }
}
