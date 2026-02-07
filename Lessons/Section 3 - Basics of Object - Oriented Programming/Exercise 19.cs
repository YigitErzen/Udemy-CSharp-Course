using System;

namespace Coding.Exercise
{
    public class DailyAccountState
    {
        public int InitialState { get; }
        
        public int SumOfOperations { get; }
        
        public DailyAccountState(int initialState, int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }
        
        // Computed property
        public int EndOfDayState
        {
            get { return InitialState + SumOfOperations; }
        }

        // Computed property
        public string Report
        {
            get
            {
                DateTime now = DateTime.Now;

                return $"Day: {now.Day}, month: {now.Month}, year: {now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
            }
        }
    }
}