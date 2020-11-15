using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dz14
{
    [Serializable]
   public class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }

    }
}
