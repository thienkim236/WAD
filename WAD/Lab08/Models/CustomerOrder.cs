﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab08.Models
{
    public class CustomerOrder
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
    }
}