using System;
using System.Collections.Generic;
using System.Text;

namespace dz13
{
    [Serializable]
    class NewCars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Cost { get; set; }
        public string NewMileage { get; set; }
    }
}
