
namespace Inventory_Management_System__BFM1_
{
    partial class AddPartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.PartName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.partid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1001;
            this.label1.Text = "Add Parts";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 1002;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In-house";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(86, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 1003;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outsourced";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PartName
            // 
            this.PartName.BackColor = System.Drawing.Color.LightSalmon;
            this.PartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartName.Location = new System.Drawing.Point(99, 87);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(189, 20);
            this.PartName.TabIndex = 1005;
            this.PartName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartName.TextChanged += new System.EventHandler(this.PartName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1004;
            this.label2.Text = "Name";
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.LightSalmon;
            this.Inventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(99, 113);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(189, 20);
            this.Inventory.TabIndex = 1007;
            this.Inventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Inventory.TextChanged += new System.EventHandler(this.Inventory_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1006;
            this.label3.Text = "Inventory";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.LightSalmon;
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(99, 139);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(118, 20);
            this.Price.TabIndex = 1009;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1008;
            this.label4.Text = "Price";
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.LightSalmon;
            this.Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(99, 165);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(71, 20);
            this.Min.TabIndex = 1011;
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min.TextChanged += new System.EventHandler(this.Min_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 1010;
            this.label5.Text = "Min";
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.Color.LightSalmon;
            this.Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(99, 191);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(71, 20);
            this.Max.TabIndex = 1013;
            this.Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Max.TextChanged += new System.EventHandler(this.Max_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1012;
            this.label6.Text = "Max";
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.LightSalmon;
            this.location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.location.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(99, 217);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(189, 20);
            this.location.TabIndex = 1015;
            this.location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.location.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-13, 219);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 1014;
            this.label7.Text = "Company Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(215, 243);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(76, 22);
            this.submit.TabIndex = 1016;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 22);
            this.button1.TabIndex = 1017;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // partid
            // 
            this.partid.BackColor = System.Drawing.Color.LightSalmon;
            this.partid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partid.Location = new System.Drawing.Point(99, 61);
            this.partid.Name = "partid";
            this.partid.Size = new System.Drawing.Size(118, 20);
            this.partid.TabIndex = 1004;
            this.partid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partid.TextChanged += new System.EventHandler(this.partid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1018;
            this.label8.Text = "PartID";
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(301, 273);
            this.Controls.Add(this.partid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PartName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPartScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddPartScreen";
            this.Load += new System.EventHandler(this.AddPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox PartName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Inventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox partid;
        private System.Windows.Forms.Label label8;
    }
}