using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Inventory_Management_System__BFM1_
{
    class Inventory : Part
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Product> AllParts { get; set; } = new BindingList<Product>();

        public static void addProduct(Product insertProduct)
        {
            if(Products.Count == 0)
            {
                Products.Add(insertProduct);
                return;
            }

            foreach (Product loopProduct in Products)
            {
                if (insertProduct.PartID <= loopProduct.PartID)
                {
                    Products.Insert(Products.IndexOf(loopProduct), insertProduct);
                    return;
                }
                
            }
            Products.Add(insertProduct);
        }
        public static bool removeProduct(int productID)
        {
            // define
            return true;
        }
        public static Product lookupProduct(int productID)
        {
            // define
            var product = Inventory.Products.SingleOrDefault(p => p.ProductID == productID);
            return product;
        }
        public static void updateProduct(int productID, Product product)
        {
            // define
        }
        public static void addPart(Product insertPart)
        {

            if (AllParts.Count == 0)
            {
                AllParts.Add(insertPart);
                return;
            }
            foreach (Product loopPart in AllParts)
            {
                if (insertPart.PartID <= loopPart.PartID)
                {
                    AllParts.Insert(AllParts.IndexOf(loopPart), insertPart);
                    return;
                }

            }
            AllParts.Add(insertPart);
        }
        public static bool deletePart(Product part)
        {
            return AllParts.Remove(part) ? true : false;
        }
        public static Product lookupPart(int partID)
        {
            var part = Inventory.AllParts.SingleOrDefault(p => p.PartID == partID);
            return part;
        }
        public static void updatePart(int partID, Part part)
        {
            // define
        }

    }
}
