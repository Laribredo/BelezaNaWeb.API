using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaNaWeb.Model.Interfaces
{
    public interface IProductViewModel
    {
        public int sku { get; set; }
        public string name { get; set; }
        public Inventory inventory { get; set; }
        public bool? isMarketable { get; set; }
    }
} 
