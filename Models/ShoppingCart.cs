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

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                if (prod.GetId() == product1.GetProduct().GetId())
                {
                    product1.SetQuantity(product1.GetQuantity() - quantity);

                    if (product1.GetQuantity() <= 0)
                    {
                        return null;
                    }
                    else
                    {
                        return product1;
                    }
                }

                else if (prod.GetId() == product2.GetProduct().GetId())
                {
                    product2.SetQuantity(product2.GetQuantity() - quantity);

                    if (product2.GetQuantity() <= 0)
                    {
                        return null;
                    }
                    else
                    {
                        return product2;
                    }
                }

                else if (prod.GetId() == product3.GetProduct().GetId())
                {
                    product3.SetQuantity(product3.GetQuantity() - quantity);

                    if (product3.GetQuantity() <= 0)
                    {
                        return null;
                    }
                    else
                    {
                        return product3;
                    }
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

        public ShoppingCartItem GetProductById(int id)
        {
            if (id == product1.GetProduct().GetId())
            {
                return product1;
            }

            else if (id == product2.GetProduct().GetId())
            { 
                return product2;
            }
            
            else if (id == product3.GetProduct().GetId())
            {
                return product3;
            }
            else
            {
                return null;
            }
        }

        public decimal GetTotal()
        {
            decimal total = (product1.GetQuantity() * product1.GetProduct().GetPrice()) +
                            (product2.GetQuantity() * product2.GetProduct().GetPrice()) +
                            (product3.GetQuantity() * product3.GetProduct().GetPrice());
            return total;
        }

        public ShoppingCartItem GetProduct(int productNum)
        {
            switch (productNum)
            {
                case 1: return product1;
                case 2: return product2;
                case 3: return product3;
                default: return null;
            }
        }
    }
}
