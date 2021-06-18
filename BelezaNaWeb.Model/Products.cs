using BelezaNaWeb.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaNaWeb.Model
{
    public class Products : IProductViewModel
    {
        public int sku { get; set; }
        public string name { get; set; }
        public Inventory inventory { get; set; }
        public bool? isMarketable { get; set; }
    }
}
