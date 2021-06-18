using BelezaNaWeb.Model.Interfaces;
using BelezaNaWeb.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BelezaNaWeb.Services
{
    public class ProductServices : IProdutcsServices
    {

        public List<IProductViewModel> products = new List<IProductViewModel>();

        public IMessageViewModel messageView { get; set; }


        public ProductServices(IMessageViewModel messageView)
        {
            this.messageView = messageView;
        }

        public IMessageViewModel CreateProduct(IProductViewModel product)
        {
            try
            {
                if (GetProductBySku(product.sku) == null)
                {
                    products.Add(product);
                    messageView.SetMessage(true, "Success");
                }
                else
                {
                    messageView.SetMessage(false, "Error : There is a product with this same SKU code.");
                }
            }
            catch (Exception e)
            {
                messageView.SetMessage(false, "Error : " + e.Message);
            }

            return messageView;

        }

        public IMessageViewModel DeleteProductBySku(int sku)
        {
            int index = products.FindIndex(s => s.sku.Equals(sku));
            if (index != -1)
            {
                products.RemoveAt(index);
                messageView.SetMessage(true, "Product successfully deleted.");
            }
            else
            {
                messageView.SetMessage(false, "Selected product does not exist in database");

            }
            return messageView;
        }

        public IMessageViewModel EditProduct(int sku,IProductViewModel product)
        {

            int index = products.FindIndex(s => s.sku.Equals(sku));
            if (index != -1)
            {
                products[index] = product;
                messageView.SetMessage(true, "Product successfully changed.");
            }
            else
            {
                messageView.SetMessage(false, "Selected product does not exist in database");

            }

            return messageView;


        }

        public IProductViewModel GetProductBySku(int sku)
        {
            //Recuperando o Produto
            IProductViewModel product = products.Where(x => x.sku.Equals(sku)).FirstOrDefault();

            if(product != null)
            {
                //Somando Quantity
                product.inventory.quantity = product.inventory.warehouses.Sum(s => s.quantity);
                //Definindo Marketable                
                product.isMarketable = (product.inventory.quantity > 0 ? true : false);
            }            

            return product;

        }
    }
}
