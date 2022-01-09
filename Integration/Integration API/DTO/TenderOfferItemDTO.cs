﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integration_API.DTO
{
    public class TenderOfferItemDTO
    {
        public int TenderingOfferItemId { get; set; }
        public string MedicineName { get; set; }
        public int MedicineDosage { get; set; }
        public int AvailableQuantity { get; set; }
        public int MissingQuantity { get; set; }
        public double PriceForSingleEntity { get; set; }
    }
}
