using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PhumlaKamnandiHotel
{
    public class Season
    {
        // Properties of the Season
        public string SeasonName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RatePerRoom { get; set; }

        // Constructor
        public Season(string seasonName, DateTime startDate, DateTime endDate, decimal ratePerRoom)
        {
            SeasonName = seasonName;
            StartDate = startDate;
            EndDate = endDate;
            RatePerRoom = ratePerRoom;
        }

        // Method to check if a given date falls within the season
        public bool IsDateInSeason(DateTime date)
        {
            return date >= StartDate && date <= EndDate;
        }

        // Static method to get the season rate for a given date
        public static decimal GetRateForDate(DateTime date, Season[] seasons)
        {
            foreach (var season in seasons)
            {
                if (season.IsDateInSeason(date))
                {
                    return season.RatePerRoom;
                }
            }
            throw new Exception("Date is not within any defined season.");
        }
    }
}
