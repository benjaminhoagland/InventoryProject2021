using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System__BFM1_
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateRefreshParts()
        {
            partsgrid.Update();
            partsgrid.Refresh();
        }
        public void UpdateRefreshProducts()
        {
            productsgrid.Update();
            productsgrid.Refresh();
        }
private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            searchpartstextbox.Text = "";
            partsgrid.ClearSelection();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            partsgrid.ClearSelection();
            if (ValidatePartSearch())
            {
                UpdateRefreshParts();
                var id = int.Parse(searchpartstextbox.Text);
                var part = Inventory.lookupPart(id);
                partsgrid.Rows[part.ProductID - 1].Selected = true;
            }
            return;
            
        }

        private bool ValidatePartSearch()
        {
            try
            {
                var id = int.Parse(searchpartstextbox.Text);
                var part = Inventory.lookupPart(id);
                // System.Windows.Forms.MessageBox.Show(part.PartID.ToString());
                if (part == null)
                {
                    MessageBox.Show("Part number not found not found in Parts, please try again.");
                    return false;
                }

            }
            catch (FormatException excp)
            {
                System.Windows.Forms.MessageBox.Show(excp.Message + "\n" + excp.StackTrace + "\nPlease search by part ID");
                return false;
            }
            catch (Exception nully)
            {
                System.Windows.Forms.MessageBox.Show("Part number not found not found in Parts, please try again.");
                return false;
            }
            return true;
        }
        private bool ValidateProductSearch()
        {
            try
            {
                var id = int.Parse(searchproductstextbox.Text);
                var prod = Inventory.lookupProduct(id);
                // System.Windows.Forms.MessageBox.Show(part.PartID.ToString());
                if (prod == null)
                {
                    MessageBox.Show("Product number not found not found in Products, please try again.");
                    return false;
                }

            }
            catch (FormatException excp)
            {
                System.Windows.Forms.MessageBox.Show(excp.Message + "\nPlease search by product ID");
                return false;
            }
            catch (Exception nully)
            {
                System.Windows.Forms.MessageBox.Show("Product number not found not found in Product, please try again.");
                return false;
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form partsScreen = new AddPartScreen();
            partsScreen.ShowDialog();
        }

        public Product GetSelectedProduct()
        {
            int selected = partsgrid.SelectedRows.Count;
            if (selected == 1)
            {
                var prod = partsgrid.SelectedRows[0].DataBoundItem as Product;
                return prod;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Warning: no product is selected.");
                return null;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int selected = partsgrid.SelectedRows.Count;
            if (selected == 1)
            {
                Form modifyPart = new ModifyPartScreen();
                modifyPart.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select a single part and try again.");
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form productScreen = new AddProductScreen();
            productScreen.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Form modifyProductScreen = new ModifyProductScreen();
            // modifyProductScreen.ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // pupulate some pars to be displayed
            new Product(1, "Engine", 100, 1, 1, 40);
            new Product(2, "Wheel", 6, 1, 1, 40);
            new Product(3, "Chassis", 15, 1, 1, 40);
            new Product(4, "Axel", 8, 1, 1, 20);
            new Product(5, "Leather Interior", 20, 1, 1, 10);
            new Product(6, "Red Paint", 4, 1, 1, 40);
            new Product(7, "Blue Paint", 4, 1, 1, 40);
            new Product(8, "Yellow Paint", 4, 1, 1, 40);
            
            
            // debug only: System.Windows.Forms.MessageBox.Show(Inventory.Products.Count.ToString());
            partsgrid.DataSource = Inventory.AllParts;
            foreach(DataGridViewColumn column in partsgrid.Columns)
            {
                column.Visible = false;
            }
            partsgrid.Columns["ProductID"].Visible = false;
            partsgrid.Columns["PartID"].Visible = true;
            partsgrid.Columns["Name"].Visible = true;
            partsgrid.Columns["Price"].Visible = true;
            partsgrid.Columns["Instock"].Visible = true;
            partsgrid.Columns["Min"].Visible = true;
            partsgrid.Columns["Max"].Visible = true;
            partsgrid.Columns["InHouse"].Visible = true;

            // populate some items to fill productsgrid
            new Product(1, "Red Car", 300, 1, 1, 3, "1", new int[] { 1, 2, 3, 4, 5, 6 });
            new Product(2, "Blue Car", 300, 1, 1, 3, "1", new int[] { 1, 2, 3, 4, 5, 7 });
            new Product(3, "Yellow Car", 300, 1, 1, 3, "1", new int[] { 1, 2, 3, 4, 5, 8 });
            productsgrid.DataSource = Inventory.Products;
            foreach (DataGridViewColumn column in productsgrid.Columns)
            {
                column.Visible = false;
            }
            productsgrid.Columns["ProductID"].Visible = true;
            productsgrid.Columns["PartID"].Visible = false;
            productsgrid.Columns["Name"].Visible = true;
            productsgrid.Columns["Price"].Visible = true;
            productsgrid.Columns["Instock"].Visible = true;
            productsgrid.Columns["Min"].Visible = true;
            productsgrid.Columns["Max"].Visible = true;
            productsgrid.Columns["InHouse"].Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in partsgrid.SelectedRows)
                Inventory.deletePart(row.DataBoundItem as Product);
                //  System.Windows.Forms.MessageBox.Show(row.DataBoundItem.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            productsgrid.ClearSelection();
            
            if (ValidateProductSearch())
            {
                UpdateRefreshProducts();
                var id = int.Parse(searchproductstextbox.Text);
                var prod = Inventory.lookupProduct(id);
                productsgrid.Rows[prod.ProductID - 1].Selected = true;
            }
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchproductstextbox.Text = "";
            productsgrid.ClearSelection();
        }
    }
}
