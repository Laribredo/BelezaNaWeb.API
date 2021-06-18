using System;
using System.Collections.Generic;

namespace BelezaNaWeb.Model
{
    public class Inventory
    {
        public int? quantity { get; set; }
        public List<Warehouse> warehouses { get; set; }
    }
}
