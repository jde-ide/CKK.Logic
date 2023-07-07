using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer customer;
        private ShoppingCartItem product1;
        private ShoppingCartItem product2;
        private ShoppingCartItem product3;

        public ShoppingCart(Customer customer)
        {
            this.customer = customer;
        }

        public int GetCustomerId()
        {
            return customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                // adding new products
                if (product1 == null)
                {
                    product1 = new ShoppingCartItem(prod, quantity);
                    return product1;
                }

                else if (product2 == null)
                {
                    product2 = new ShoppingCartItem(prod, quantity);
                    return product2;
                }

                else if (product3 == null)
                {
                    product3 = new ShoppingCartItem(prod, quantity);
                    return product3;
                }

                // adding quantity of existing products
                else if (prod.GetId() == product1.GetProduct().GetId())
                {
                    product1.SetQuantity(product1.GetQuantity() + quantity);
                    return product1;
                }

                else if (prod.GetId() == product2.GetProduct().GetId())
                {
                    product2.SetQuantity(product2.GetQuantity() + quantity);
                    return product2;
                }

                else if (prod.GetId() == product3.GetProduct().GetId())
                {
                    product3.SetQuantity(product3.GetQuantity() + quantity);
                    return product3;
                }

                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            // adding new products
            if (product1 == null)
            {
                product1 = new ShoppingCartItem(prod, 1);
                return product1;
            }

            else if (product2 == null)
            {
                product2 = new ShoppingCartItem(prod, 1);
                return product2;
            }

            else if (product3 == null)
            {
                product3 = new ShoppingCartItem(prod, 1);
                return product3;
            }

            // adding 1 to current quantity of existing products
            else if (prod.GetId() == product1.GetProduct().GetId())
            {
                product1.SetQuantity(product1.GetQuantity() + 1);
                return product1;
            }

            else if (prod.GetId() == product2.GetProduct().GetId())
            {
                product2.SetQuantity(product2.GetQuantity() + 1);
                return product2;
            }

            else if (prod.GetId() == product3.GetProduct().GetId())
            {
                product3.SetQuantity(product3.GetQuantity() + 1);
                return product3;
            }

            else
            {
                return null;
            }
        }


    }
}
