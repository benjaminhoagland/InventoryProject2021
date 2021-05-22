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
    public partial class AddProductScreen : Form
    {
        private string textBox6name;
        private bool inhouse = true;
        private BindingList<Product> availParts = new BindingList<Product>();
        private BindingList<Product> assocParts = new BindingList<Product>();

        public AddProductScreen()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
            inhouse = true;
            textBox6name = label7.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
            inhouse = false;
            textBox6name = label7.Text;
        }

        private void AddPartScreen_Load(object sender, EventArgs e)
        {
            assocpartsgrid.DataSource = assocParts;

            assocpartsgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            availpartsgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            availParts = Inventory_Management_System__BFM1_.Inventory.NewBindingListFromOld(Inventory_Management_System__BFM1_.Inventory.AllParts);

            availpartsgrid.DataSource = availParts;

            foreach (DataGridViewColumn column in availpartsgrid.Columns)
            {
                column.Visible = false;
            }
            availpartsgrid.Columns["ProductID"].Visible = false;
            availpartsgrid.Columns["PartID"].Visible = true;
            availpartsgrid.Columns["Name"].Visible = true;
            availpartsgrid.Columns["Price"].Visible = true;
            availpartsgrid.Columns["Instock"].Visible = true;
            availpartsgrid.Columns["Min"].Visible = true;
            availpartsgrid.Columns["Max"].Visible = true;

            foreach (DataGridViewColumn column in assocpartsgrid.Columns)
            {
                column.Visible = false;
            }
            assocpartsgrid.Columns["ProductID"].Visible = false;
            assocpartsgrid.Columns["PartID"].Visible = true;
            assocpartsgrid.Columns["Name"].Visible = true;
            assocpartsgrid.Columns["Price"].Visible = true;
            assocpartsgrid.Columns["Instock"].Visible = true;
            assocpartsgrid.Columns["Min"].Visible = true;
            assocpartsgrid.Columns["Max"].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var id = int.Parse(productid.Text);
                if (Inventory_Management_System__BFM1_.Inventory.Products.Contains(Inventory_Management_System__BFM1_.Inventory.lookupProduct(id)))
                {
                    // product already exists
                    MessageBox.Show($"Product already exists, adding Inventory field to Instock quantity.");
                    Inventory_Management_System__BFM1_.Inventory.lookupProduct(id).InStock += int.Parse(Inventory.Text);
                    var mainscreen = Application.OpenForms[0] as MainScreen;
                    mainscreen.UpdateRefreshProducts();
                    this.Close();
                    return;
                }


                if (assocParts.Count < 1)
                {
                    MessageBox.Show("Please add at least one associated part, and submit again.");
                    return;
                }

                new Product
                (
                    int.Parse(productid.Text),
                    productname.Text,
                    int.Parse(Price.Text),
                    int.Parse(Inventory.Text),
                    int.Parse(Min.Text),
                    int.Parse(Max.Text),
                    location.Text,
                    // list associated parts
                    Product.BuildPartIDListFromProducts(assocParts)
                ) ;
                
                this.Close();
                return;
                
            }
        }

        private bool ValidateInput()
        {
            var controlsToValidate = Controls.OfType<TextBox>().OrderBy(control => control.TabIndex);

            foreach (var textBox in controlsToValidate)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Focus();

                    // remove "txt" prefix:
                    if (textBox.Name == "textBox6")
                    {
                        var fieldName = label7.Text;
                        MessageBox.Show(string.Format("'{0}' is required.", fieldName));
                        textBox.BackColor = System.Drawing.Color.LightSalmon;
                    }
                    else
                    {
                        var fieldName = textBox.Name;
                        MessageBox.Show(string.Format("'{0}' is required.", fieldName));
                        // textBox.BackColor = Color.LightSalmon;
                    }
                    return false;
                }
                try
                {
                    int.Parse(productid.Text);
                    // PartName.Text;
                    int.Parse(Price.Text);
                    var quant = int.Parse(Inventory.Text);
                    var min = int.Parse(Min.Text);
                    var max = int.Parse(Max.Text);

                    if ((quant < min) || (quant > max))
                    {
                        throw new Exception("Inventory must be between Min and Max.");

                    }
                }
                catch (FormatException excp)
                {
                    System.Windows.Forms.MessageBox.Show($"Please enter a number for ID, Price, Inventory, Min, and Max.");
                    return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (inhouse)
                {
                    try
                    {
                        var id = int.Parse(location.Text);
                    }
                    catch (FormatException e)
                    {
                        System.Windows.Forms.MessageBox.Show($"Please enter a NUMBER for {label7.Text}");
                        return false;
                    }
                }
                else
                {
                    try
                    {
                        var companyName = label7.Text;
                    }
                    catch (FormatException e)
                    {
                        System.Windows.Forms.MessageBox.Show($"Please enter a NAME for {label7.Text}");
                        return false;
                    }
                }
            }
            return true;
        }
        private void partid_TextChanged(object sender, EventArgs e)
        {
            productid.BackColor = String.IsNullOrEmpty(productid.Text) ? Color.LightSalmon : Color.White;
        }
        private void PartName_TextChanged(object sender, EventArgs e)
        {
            productname.BackColor = String.IsNullOrEmpty(productname.Text) ? Color.LightSalmon : Color.White;
        }

        private void Inventory_TextChanged(object sender, EventArgs e)
        {
            Inventory.BackColor = String.IsNullOrEmpty(Inventory.Text) ? Color.LightSalmon : Color.White;
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            Price.BackColor = String.IsNullOrEmpty(Price.Text) ? Color.LightSalmon : Color.White;
        }

        private void Min_TextChanged(object sender, EventArgs e)
        {
            Min.BackColor = String.IsNullOrEmpty(Min.Text) ? Color.LightSalmon : Color.White;
        }

        private void Max_TextChanged(object sender, EventArgs e)
        {
            Max.BackColor = String.IsNullOrEmpty(Max.Text) ? Color.LightSalmon : Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            location.BackColor = String.IsNullOrEmpty(location.Text) ? Color.LightSalmon : Color.White;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void searchprodbutton_Click(object sender, EventArgs e)
        {
            assocpartsgrid.ClearSelection();
            if (ValidatePartSearchAssoc())
            {
                assocpartsgrid.Update();
                assocpartsgrid.Refresh();
                var id = int.Parse(searchassocpartsbox.Text);
                var part = Inventory_Management_System__BFM1_.Inventory.lookupPart(id);
                try
                {
                    assocpartsgrid.Rows[SearchFor.PartInDataGridView(part, assocpartsgrid)].Selected = true;
                }
                catch
                {
                    MessageBox.Show($"Part number {id} was not found not found in Parts, please try again.");
                }
            }
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            availpartsgrid.ClearSelection();
            if (ValidatePartSearchAvail())
            {
                availpartsgrid.Update();
                availpartsgrid.Refresh();
                var id = int.Parse(searchavailpartsbox.Text);
                var part = Inventory_Management_System__BFM1_.Inventory.lookupPart(id);
                try
                {
                    availpartsgrid.Rows[SearchFor.PartInDataGridView(part, availpartsgrid)].Selected = true;
                }
                catch
                {
                    MessageBox.Show($"Part number {id} was not found not found in Parts, please try again.");
                }
            }
            return;
        }
        private bool ValidatePartSearchAssoc()
        {
            try
            {
                var id = int.Parse(searchassocpartsbox.Text);
                var part = Inventory_Management_System__BFM1_.Inventory.lookupPart(id);
                // System.Windows.Forms.MessageBox.Show(part.PartID.ToString());
                if (part == null)
                {
                    MessageBox.Show("Part number not found not found in Parts, please try again.");
                    return false;
                }

            }
            catch (FormatException excp)
            {
                System.Windows.Forms.MessageBox.Show("Please search by part ID");
                return false;
            }
            catch (Exception nully)
            {
                System.Windows.Forms.MessageBox.Show("Part number not found not found in Parts, please try again.");
                return false;
            }
            return true;
        }
        private bool ValidatePartSearchAvail()
        {
            try
            {
                var id = int.Parse(searchavailpartsbox.Text);
                var part = Inventory_Management_System__BFM1_.Inventory.lookupPart(id);
                // System.Windows.Forms.MessageBox.Show(part.PartID.ToString());
                if (part == null)
                {
                    MessageBox.Show("Part number not found not found in Parts, please try again.");
                    return false;
                }

            }
            catch (FormatException excp)
            {
                System.Windows.Forms.MessageBox.Show("Please search by part ID");
                return false;
            }
            catch (Exception nully)
            {
                System.Windows.Forms.MessageBox.Show("Part number not found not found in Parts, please try again.");
                return false;
            }
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // move associated to available
            int id = -1;

            if (assocpartsgrid.SelectedRows.Count != 1)
            {
                MessageBox.Show($"Please select a single row and try again.");
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                try
                {
                    id = int.Parse(assocpartsgrid.SelectedRows[0].Cells[0].Value.ToString());
                    var part = Inventory_Management_System__BFM1_.Inventory.lookupPart(id);

                    assocParts.Remove(part);
                    assocpartsgrid.Update();
                    assocpartsgrid.Refresh();

                    availParts.Add(part);
                    availpartsgrid.Refresh();
                    availpartsgrid.Refresh();
                }
                catch
                {
                    MessageBox.Show($"Part number {id} was not found not found in Parts, please try again.");
                    return;
                }
            }
            else
            {
                return;
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // add associated
            int id = -1;

            if (availpartsgrid.SelectedRows.Count != 1)
            {
                MessageBox.Show($"Please select a single row and try again.");
                return;
            }
            try
            {
                id = int.Parse(availpartsgrid.SelectedRows[0].Cells[0].Value.ToString());
                var part = Inventory_Management_System__BFM1_.Inventory.lookupPart(id);

                assocParts.Add(part);
                assocpartsgrid.Update();
                assocpartsgrid.Refresh();

                availParts.Remove(part);
                availpartsgrid.Refresh();
                availpartsgrid.Refresh();
            }
            catch
            {
                MessageBox.Show($"Part number {id.ToString()} was not found not found in Parts, please try again.");
                return;
            }
        }

        private void availpartsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}