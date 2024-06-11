using System;

namespace example
{
	public class Town
	{
        public string Name = "";
		public string Country = "";
		public string Region = "";
		public int Population = 0;
		public double YearIncome = 0;
		public double Square = 0;
		public bool HasPort;
        public bool HasAirport;

        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }
    }
}

