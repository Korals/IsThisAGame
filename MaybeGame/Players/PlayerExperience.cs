using System;

namespace MaybeGame.Players
{
    public class PlayerExperience
    {
        public PlayerExperience()
        {
            ExperiencePoints = 0;
            Level = 1;
        }

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