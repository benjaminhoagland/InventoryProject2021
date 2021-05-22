using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Inventory_Management_System__BFM1_
{
    public class Product : Part
    {
        private static int productGUIDCounter = 0;
        public BindingList<Product> AssociatedParts { get; set; } = new BindingList<Product>();
        public int ProductID { get; private set; } // private set during construction
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min{ get; set; }
        public int Max { get; set; }
        public string Location { get; set; }
        
        public Product(int partID, string name, decimal price, int instock, int min, int max, string loc = "1")
        {
            ProductID = partID; // Product.GetNewGUID();
            PartID = partID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            Location = loc;
            
            Inventory.addPart(this);
        }
        public Product(int partID, string name, decimal price, int instock, int min, int max, string loc, List<int> associatedPartIDs)
        {
            ProductID = partID; // Product.GetNewGUID();
            PartID = partID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            Location = loc;

            foreach (int id in associatedPartIDs)
            {
                this.addAssociatedPart(Inventory.lookupPart(id));
            }    
            Inventory.addProduct(this);
        }

        public static List<int> BuildPartIDListFromProducts(BindingList<Product> products)
        {
            var convertedList = new List<int>();
            foreach (var item in products)
            {
                convertedList.Add(item.PartID);
            }
            return convertedList;
        }
        public void addAssociatedPart(Product insertPart)
        {
            if (AssociatedParts.Count == 0)
            {
                AssociatedParts.Add(insertPart);
                return;
            }

            foreach (Product loopPart in AssociatedParts)
            {
                if (insertPart.PartID <= loopPart.PartID)
                {
                    AssociatedParts.Insert(AssociatedParts.IndexOf(loopPart), insertPart);
                    return;
                }

            }
            AssociatedParts.Add(insertPart);
        }

        public static int GetNewGUID()
        {
            var newProductGUID = productGUIDCounter++;
            return newProductGUID;
        }
        public void addAssociatedPart(Part part)
        {
            // define
        }
        public void removeAssoicatedPart(int partID)
        {
            foreach (Product loopPart in AssociatedParts)
            {
                if (loopPart.PartID == partID)
                {
                    AssociatedParts.Remove(loopPart);
                    return;
                }

            }
        }
        public void lookupAssoicatedPart(int partID)
        {
            // define : Part
        }
    }
}
