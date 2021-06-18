using System;
using System.Collections.Generic;
using System.Text;
using BelezaNaWeb.Model.Interfaces;

namespace BelezaNaWeb.Services.Interfaces
{
    public interface IProdutcsServices
    {
        IMessageViewModel messageView { get; set; }

        IMessageViewModel CreateProduct(IProductViewModel product);

        IMessageViewModel EditProduct(int sku, IProductViewModel product);

        IProductViewModel GetProductBySku(int sku);

        IMessageViewModel DeleteProductBySku(int sku);
    }
}
