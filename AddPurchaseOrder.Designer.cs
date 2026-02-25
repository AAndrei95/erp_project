namespace Digital_Shop_Software
{
    partial class AddPurchaseOrder
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
            textBox10 = new TextBox();
            po_date = new DateTimePicker();
            textBox8 = new TextBox();
            o_val = new TextBox();
            textBox3 = new TextBox();
            category = new TextBox();
            textBox7 = new TextBox();
            addValues = new Button();
            CloseButton = new Button();
            textBox6 = new TextBox();
            s_qty = new TextBox();
            textBox5 = new TextBox();
            qty = new TextBox();
            textBox4 = new TextBox();
            textBox21 = new TextBox();
            p_name = new TextBox();
            textBox1 = new TextBox();
            textBox9 = new TextBox();
            Instruction_txt = new TextBox();
            p_code = new ComboBox();
            textBox16 = new TextBox();
            textBox2 = new TextBox();
            del_date = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(0, 70, 60);
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox10.ForeColor = Color.Linen;
            textBox10.Location = new Point(12, 291);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(186, 31);
            textBox10.TabIndex = 84;
            textBox10.Text = "PO Date";
            // 
            // po_date
            // 
            po_date.Location = new Point(204, 291);
            po_date.Name = "po_date";
            po_date.Size = new Size(231, 31);
            po_date.TabIndex = 83;
            po_date.ValueChanged += po_date_ValueChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(0, 70, 60);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.FromArgb(255, 201, 134);
            textBox8.Location = new Point(441, 254);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(43, 31);
            textBox8.TabIndex = 79;
            textBox8.Text = "£";
            // 
            // o_val
            // 
            o_val.Enabled = false;
            o_val.Location = new Point(204, 254);
            o_val.Name = "o_val";
            o_val.Size = new Size(231, 31);
            o_val.TabIndex = 78;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 70, 60);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Linen;
            textBox3.Location = new Point(12, 254);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 31);
            textBox3.TabIndex = 77;
            textBox3.Text = "Order Value";
            // 
            // category
            // 
            category.Enabled = false;
            category.Location = new Point(204, 143);
            category.Name = "category";
            category.Size = new Size(231, 31);
            category.TabIndex = 76;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(0, 70, 60);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Linen;
            textBox7.Location = new Point(12, 143);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(186, 31);
            textBox7.TabIndex = 75;
            textBox7.Text = "Category";
            // 
            // addValues
            // 
            addValues.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addValues.BackColor = Color.White;
            addValues.FlatAppearance.BorderColor = Color.Red;
            addValues.FlatAppearance.MouseOverBackColor = Color.Red;
            addValues.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addValues.ForeColor = Color.FromArgb(0, 70, 60);
            addValues.ImageAlign = ContentAlignment.MiddleRight;
            addValues.ImeMode = ImeMode.NoControl;
            addValues.Location = new Point(478, 373);
            addValues.Name = "addValues";
            addValues.Size = new Size(112, 34);
            addValues.TabIndex = 74;
            addValues.Text = "Add";
            addValues.TextAlign = ContentAlignment.TopLeft;
            addValues.UseVisualStyleBackColor = false;
            addValues.Click += addValues_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CloseButton.BackColor = Color.White;
            CloseButton.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 60);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.FromArgb(0, 70, 60);
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(12, 372);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 34);
            CloseButton.TabIndex = 73;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(0, 70, 60);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.FromArgb(255, 201, 134);
            textBox6.Location = new Point(441, 217);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(43, 31);
            textBox6.TabIndex = 72;
            textBox6.Text = "*";
            // 
            // s_qty
            // 
            s_qty.Enabled = false;
            s_qty.Location = new Point(204, 180);
            s_qty.Name = "s_qty";
            s_qty.Size = new Size(231, 31);
            s_qty.TabIndex = 71;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(0, 70, 60);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Linen;
            textBox5.Location = new Point(12, 180);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 31);
            textBox5.TabIndex = 70;
            textBox5.Text = "Current Stock";
            // 
            // qty
            // 
            qty.Location = new Point(204, 217);
            qty.Name = "qty";
            qty.Size = new Size(231, 31);
            qty.TabIndex = 69;
            qty.TextChanged += qty_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(0, 70, 60);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Linen;
            textBox4.Location = new Point(12, 217);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 31);
            textBox4.TabIndex = 68;
            textBox4.Text = "Order Quantity";
            // 
            // textBox21
            // 
            textBox21.BackColor = Color.FromArgb(0, 70, 60);
            textBox21.BorderStyle = BorderStyle.None;
            textBox21.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox21.ForeColor = Color.FromArgb(255, 201, 134);
            textBox21.Location = new Point(441, 67);
            textBox21.Multiline = true;
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(43, 31);
            textBox21.TabIndex = 67;
            textBox21.Text = "*";
            // 
            // p_name
            // 
            p_name.Enabled = false;
            p_name.Location = new Point(204, 106);
            p_name.Name = "p_name";
            p_name.Size = new Size(231, 31);
            p_name.TabIndex = 66;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 70, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Linen;
            textBox1.Location = new Point(12, 106);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 31);
            textBox1.TabIndex = 65;
            textBox1.Text = "Product Name";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(0, 70, 60);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.ForeColor = Color.Linen;
            textBox9.Location = new Point(65, 34);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(475, 29);
            textBox9.TabIndex = 64;
            textBox9.Text = "All fields marked with \"*\" should be completed";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // Instruction_txt
            // 
            Instruction_txt.BackColor = Color.FromArgb(0, 70, 60);
            Instruction_txt.BorderStyle = BorderStyle.None;
            Instruction_txt.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Instruction_txt.ForeColor = Color.Linen;
            Instruction_txt.Location = new Point(65, 10);
            Instruction_txt.Multiline = true;
            Instruction_txt.Name = "Instruction_txt";
            Instruction_txt.Size = new Size(475, 29);
            Instruction_txt.TabIndex = 63;
            Instruction_txt.Text = "Please fill up the form below with the product details";
            Instruction_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // p_code
            // 
            p_code.FormattingEnabled = true;
            p_code.Location = new Point(204, 67);
            p_code.Name = "p_code";
            p_code.Size = new Size(231, 33);
            p_code.TabIndex = 62;
            p_code.SelectedValueChanged += p_code_SelectedValueChanged;
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.FromArgb(0, 70, 60);
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox16.ForeColor = Color.Linen;
            textBox16.Location = new Point(12, 69);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(186, 31);
            textBox16.TabIndex = 61;
            textBox16.Text = "Product Code";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 70, 60);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Linen;
            textBox2.Location = new Point(12, 328);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 31);
            textBox2.TabIndex = 86;
            textBox2.Text = "Delivery Date";
            // 
            // del_date
            // 
            del_date.Location = new Point(204, 328);
            del_date.Name = "del_date";
            del_date.Size = new Size(231, 31);
            del_date.TabIndex = 85;
            // 
            // AddPurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 60);
            ClientSize = new Size(602, 417);
            Controls.Add(textBox2);
            Controls.Add(del_date);
            Controls.Add(textBox10);
            Controls.Add(po_date);
            Controls.Add(textBox8);
            Controls.Add(o_val);
            Controls.Add(textBox3);
            Controls.Add(category);
            Controls.Add(textBox7);
            Controls.Add(addValues);
            Controls.Add(CloseButton);
            Controls.Add(textBox6);
            Controls.Add(s_qty);
            Controls.Add(textBox5);
            Controls.Add(qty);
            Controls.Add(textBox4);
            Controls.Add(textBox21);
            Controls.Add(p_name);
            Controls.Add(textBox1);
            Controls.Add(textBox9);
            Controls.Add(Instruction_txt);
            Controls.Add(p_code);
            Controls.Add(textBox16);
            Name = "AddPurchaseOrder";
            Text = "Add Purchase Order";
            Load += AddPurchaseOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox10;
        public DateTimePicker po_date;
        private TextBox textBox8;
        public TextBox o_val;
        private TextBox textBox3;
        public TextBox category;
        private TextBox textBox7;
        private Button addValues;
        private Button CloseButton;
        private TextBox textBox6;
        public TextBox s_qty;
        private TextBox textBox5;
        public TextBox qty;
        private TextBox textBox4;
        private TextBox textBox21;
        public TextBox p_name;
        private TextBox textBox1;
        private TextBox textBox9;
        private TextBox Instruction_txt;
        public ComboBox p_code;
        private TextBox textBox16;
        private TextBox textBox2;
        public DateTimePicker del_date;
    }
}