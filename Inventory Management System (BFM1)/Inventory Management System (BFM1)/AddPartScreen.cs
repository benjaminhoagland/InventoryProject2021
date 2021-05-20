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
    public partial class AddPartScreen : Form
    {
        private string textBox6name;
        private bool inhouse = true;

        public AddPartScreen()
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var id = int.Parse(partid.Text);
                if (Inventory_Management_System__BFM1_.Inventory.AllParts.Contains(Inventory_Management_System__BFM1_.Inventory.lookupPart(id)))
                {
                    // product already exists
                    MessageBox.Show($"Product already exists, adding Inventory field to Instock quantity.");
                    Inventory_Management_System__BFM1_.Inventory.lookupPart(id).InStock += int.Parse(Inventory.Text);
                    var mainscreen = Application.OpenForms[0] as MainScreen;
                    mainscreen.UpdateRefreshParts();
                    this.Close();
                    return;
                }

                new Product
                (
                    int.Parse(partid.Text),
                    PartName.Text,
                    int.Parse(Price.Text),
                    int.Parse(Inventory.Text),
                    int.Parse(Min.Text),
                    int.Parse(Max.Text),
                    location.Text
                );
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
                    int.Parse(partid.Text);
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
                    System.Windows.Forms.MessageBox.Show($"\nPlease enter a number for ID, Price, Inventory, Min, and Max.");
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
                        System.Windows.Forms.MessageBox.Show(e.Message + $"\nPlease enter a NUMBER for {label7.Text}");
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
                        System.Windows.Forms.MessageBox.Show(e.Message + $"\nPlease enter a NAME for {label7.Text}");
                        return false;
                    }
                }
            }
            return true;
        }
        private void partid_TextChanged(object sender, EventArgs e)
        {
            partid.BackColor = String.IsNullOrEmpty(partid.Text) ? Color.LightSalmon : Color.White;
        }
        private void PartName_TextChanged(object sender, EventArgs e)
        {
            PartName.BackColor = String.IsNullOrEmpty(PartName.Text) ? Color.LightSalmon : Color.White;
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
    }
}