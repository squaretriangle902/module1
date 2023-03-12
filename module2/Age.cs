﻿namespace module2
{
    internal struct Age
    {
        internal int year;
        internal int month;
        internal int day;

        internal Age(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public override string ToString()
        {
            return String.Format("years: {0}, months: {1}, days: {2}", year, month, day);
        }
    }
}
