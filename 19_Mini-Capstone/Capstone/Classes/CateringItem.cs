﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class CateringItem
    {
        // This class should contain the definition for one catering item

        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string ItemClass { get; set; }
        public int ItemQty { get; set; } = 50;


        

    }
}
