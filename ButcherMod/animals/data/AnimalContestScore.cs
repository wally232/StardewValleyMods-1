﻿namespace AnimalHusbandryMod.animals.data
{
    public class AnimalContestScore
    {
        public int FriendshipPoints;
        public int MonthsOld;
        public int AgePoints;
        public int TreatVariatyPoints;
        public int TreatAveragePoints;
        public int ParentWinnerPoints;
        public int TotalPoints => FriendshipPoints + AgePoints + TreatVariatyPoints + TreatAveragePoints + ParentWinnerPoints;

        public AnimalContestScore(int friendshipPoints, int monthsOld, int agePoints, int treatVariatyPoints, int treatAveragePoints, int parentWinnerPoints)
        {
            this.FriendshipPoints = friendshipPoints;
            this.MonthsOld = monthsOld;
            this.AgePoints = agePoints;
            this.TreatVariatyPoints = treatVariatyPoints;
            this.TreatAveragePoints = treatAveragePoints;
            this.ParentWinnerPoints = parentWinnerPoints;
        }
    }
}