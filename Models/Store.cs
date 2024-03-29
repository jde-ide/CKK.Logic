﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int id;
        private string name;
        private Product product1;
        private Product product2;
        private Product product3;

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddStoreItem(Product prod)
        {
            if (product1 == null)
            {
                product1 = prod;
            }
            else if (product2 == null)
            {
                product2 = prod;
            }
            else if (product3 == null)
            {
                product3 = prod;
            }
        }

        public void RemoveStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                product1 = null;
            }
            else if (productNumber == 2)
            {
                product2 = null;
            }
            else if (productNumber == 3)
            {
                product3 = null;
            }
        }

        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                return product1;
            }
            else if (productNumber == 2)
            {
                return product2;
            }
            else if (productNumber == 3)
            {
                return product3;
            }
            else
            {
                return null;
            }
        }

        public Product FindStoreItemById(int id)
        {
            if (id == product1.GetId())
            {
                return product1;
            }
            else if (id == product2.GetId())
            {
                return product2;
            }
            else if (id == product3.GetId())
            {
                return product3;
            }
            else
            {
                return null;
            }
        }
    }
}