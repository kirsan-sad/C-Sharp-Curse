using System;
using System.Collections.Generic;
using System.Text;

namespace dz13
{
    [Serializable]
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Mileage { get; set; }
        public decimal FirstPrice { get; set; }
        public decimal NowPrice { get; set; }

        decimal lowCost;

        public string Cost { get; set; }
        public string NewMileage { get; set; }

        private int getYear()
        {
        return DateTime.Now.Year - Year.Year;
        }

        public void getCost(int year)
        {
            lowCost = ((FirstPrice - NowPrice) / getYear()) * year;
            if (lowCost > FirstPrice) 
                Cost = "Машина утилизирована";
            else 
                Cost = $"За {year} лет, машина подешевеет на {lowCost.ToString("f1")}$";
        }
        
        public void getMileage(int year)
        {
            int tempMileage = (Mileage / getYear()) * year;
            if (lowCost > FirstPrice)
                NewMileage = $"В {Year.AddYears(year).ToString("yyyy")} году, машина накатала бы пробег {tempMileage}км";
            else
                NewMileage = $"За {year} лет, машина накатает пробег {tempMileage}км";
        }

    }
}
