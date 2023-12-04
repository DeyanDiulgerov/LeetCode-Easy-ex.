using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumHoursOfTrainingToWinACompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumHoursOfTrainingToWinACompetition(2, 2, new int[] { 1 }, new int[] { 2 }));
            Console.WriteLine(MinimumHoursOfTrainingToWinACompetition(68, 23,
                new int[] { 71, 69, 61, 63, 43, 85, 41, 35, 39, 24, 14, 21, 41, 54, 67,
                    10, 89, 88, 56, 52, 27, 56, 71, 74, 83, 23, 24, 11, 15, 69, 16, 10, 77, 55 },
                new int[] { 45, 96, 74, 96, 1, 78, 44, 36, 40, 11, 10, 14, 89, 25, 74,
                    65, 20, 54, 4, 74, 83, 9, 91, 83, 17, 30, 88, 13, 77, 93, 47, 30, 72, 20 }));
            Console.WriteLine(MinimumHoursOfTrainingToWinACompetition(94, 70,
                new int[] { 58, 47, 100, 71, 47, 6, 92, 82, 35, 16, 50, 15, 42, 5, 2, 45, 22 },
                new int[] { 77, 83, 99, 76, 75, 66, 58, 84, 44, 98, 70, 41, 48, 7, 10, 61, 28 }));
            Console.WriteLine(MinimumHoursOfTrainingToWinACompetition(1, 1, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 50 }));
            Console.WriteLine(MinimumHoursOfTrainingToWinACompetition(5, 3, new int[] { 1, 4 }, new int[] { 2, 5 }));
            Console.WriteLine(MinimumHoursOfTrainingToWinACompetition(5, 3, new int[] { 1, 4, 3, 2 }, new int[] { 2, 6, 3, 1 }));
            Console.WriteLine(MinimumHoursOfTrainingToWinACompetition(2, 4, new int[] { 1 }, new int[] { 3 }));
        }

        public static int MinimumHoursOfTrainingToWinACompetition
            (int initialEnergy, int initialExperience, int[] energy, int[] experience)
        {
            var result = 0;
            if (energy.Sum() > initialEnergy)
                result += energy.Sum() - initialEnergy + 1;
            else if (energy.Sum() == initialEnergy)
                result += 1;
            if (experience.Sum() < initialExperience)
                return result;
            else if (experience.Sum() == initialExperience && experience.Length == 1)
                return result + 1;
            else if (experience.Sum() == initialExperience)
                return result;
            else
            {
                bool isEqual = false;
                for (int i = 0; i < experience.Length; i++)
                {
                    if (experience[i] < initialExperience)
                        initialExperience += experience[i];
                    else if (experience[i] == initialExperience)
                    {
                        isEqual = true;
                        result++;
                        initialExperience++;
                    }
                    else
                    {
                        if (!isEqual)
                            result += experience[i] - initialExperience + 1;
                        else
                            result += experience[i] - initialExperience;

                        initialExperience += experience[i] - initialExperience + 1;
                        initialExperience += experience[i];
                        if (initialExperience > experience.Max())
                            break;
                    }
                }
            }
            return result;
        }
    }
}
