﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// 5 stars hotel
    /// </summary>
    class UltraLuxuryHotel : Hotel
    {
        public UltraLuxuryHotel(string city) : base(city,5)
        {

        }

        public override bool addRoom()
        {
            throw new NotImplementedException();
        }
    }
}
