using System;

namespace MaybeGame
{
    public class PlayerExperience
    {
        public double ExperiencePoints { get; set; }
        //public double SavedExperiencePoints { get; set; }
        public int Level { get; set; }

        public void IsLevelUpPossible(double experiencePoints)
        {
            if (experiencePoints >= 1)
            {
                Level++;
                Console.WriteLine("Level up! Congratulations\n" +
                    $"Your level is now {Level}");
                ExperiencePoints -= 1;
            }
            else
            {
                ExperiencePoints += experiencePoints;
            }

        }

        /*public double SaveExperiencePoints(double experiencePoints)
        {
           return SavedExperiencePoints += experiencePoints;
        }*/
    }
}
