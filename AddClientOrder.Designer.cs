namespace Digital_Shop_Software
{
    partial class AddClientOrder
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
            p_code = new ComboBox();
            textBox16 = new TextBox();
            textBox9 = new TextBox();
            Instruction_txt = new TextBox();
            textBox1 = new TextBox();
            p_name = new TextBox();
            textBox21 = new TextBox();
            qty = new TextBox();
            textBox4 = new TextBox();
            s_qty = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            addValues = new Button();
            CloseButton = new Button();
            category = new TextBox();
            textBox7 = new TextBox();
            o_val = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            checkBox1 = new CheckBox();
            clientid = new ComboBox();
            textBox2 = new TextBox();
            order_date = new DateTimePicker();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            SuspendLayout();
            // 
            // p_code
            // 
            p_code.FormattingEnabled = true;
            p_code.Location = new Point(204, 149);
            p_code.Name = "p_code";
            p_code.Size = new Size(231, 33);
            p_code.TabIndex = 36;
            p_code.SelectedValueChanged += p_code_SelectedValueChanged;
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.FromArgb(0, 70, 60);
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox16.ForeColor = Color.Linen;
            textBox16.Location = new Point(12, 151);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(186, 31);
            textBox16.TabIndex = 35;
            textBox16.Text = "Product Code";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(0, 70, 60);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.ForeColor = Color.Linen;
            textBox9.Location = new Point(65, 33);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(475, 29);
            textBox9.TabIndex = 38;
            textBox9.Text = "All fields marked with \"*\" should be completed";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // Instruction_txt
            // 
            Instruction_txt.BackColor = Color.FromArgb(0, 70, 60);
            Instruction_txt.BorderStyle = BorderStyle.None;
            Instruction_txt.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Instruction_txt.ForeColor = Color.Linen;
            Instruction_txt.Location = new Point(65, 9);
            Instruction_txt.Multiline = true;
            Instruction_txt.Name = "Instruction_txt";
            Instruction_txt.Size = new Size(475, 29);
            Instruction_txt.TabIndex = 37;
            Instruction_txt.Text = "Please fill up the form below with the product details";
            Instruction_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 70, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Linen;
            textBox1.Location = new Point(12, 188);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 31);
            textBox1.TabIndex = 39;
            textBox1.Text = "Product Name";
            // 
            // p_name
            // 
            p_name.Enabled = false;
            p_name.Location = new Point(204, 188);
            p_name.Name = "p_name";
            p_name.Size = new Size(231, 31);
            p_name.TabIndex = 40;
            // 
            // textBox21
            // 
            textBox21.BackColor = Color.FromArgb(0, 70, 60);
            textBox21.BorderStyle = BorderStyle.None;
            textBox21.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox21.ForeColor = Color.FromArgb(255, 201, 134);
            textBox21.Location = new Point(441, 149);
            textBox21.Multiline = true;
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(43, 31);
            textBox21.TabIndex = 41;
            textBox21.Text = "*";
            // 
            // qty
            // 
            qty.Location = new Point(204, 299);
            qty.Name = "qty";
            qty.Size = new Size(231, 31);
            qty.TabIndex = 44;
            qty.TextChanged += qty_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(0, 70, 60);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Linen;
            textBox4.Location = new Point(12, 299);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 31);
            textBox4.TabIndex = 43;
            textBox4.Text = "Order Quantity";
            // 
            // s_qty
            // 
            s_qty.Enabled = false;
            s_qty.Location = new Point(204, 262);
            s_qty.Name = "s_qty";
            s_qty.Size = new Size(231, 31);
            s_qty.TabIndex = 46;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(0, 70, 60);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Linen;
            textBox5.Location = new Point(12, 262);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 31);
            textBox5.TabIndex = 45;
            textBox5.Text = "Stock Quantity";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(0, 70, 60);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.FromArgb(255, 201, 134);
            textBox6.Location = new Point(441, 299);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(43, 31);
            textBox6.TabIndex = 47;
            textBox6.Text = "*";
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
            addValues.Location = new Point(478, 431);
            addValues.Name = "addValues";
            addValues.Size = new Size(112, 34);
            addValues.TabIndex = 49;
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
            CloseButton.Location = new Point(12, 430);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 34);
            CloseButton.TabIndex = 48;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // category
            // 
            category.Enabled = false;
            category.Location = new Point(204, 225);
            category.Name = "category";
            category.Size = new Size(231, 31);
            category.TabIndex = 51;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(0, 70, 60);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Linen;
            textBox7.Location = new Point(12, 225);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(186, 31);
            textBox7.TabIndex = 50;
            textBox7.Text = "Category";
            // 
            // o_val
            // 
            o_val.Enabled = false;
            o_val.Location = new Point(204, 336);
            o_val.Name = "o_val";
            o_val.Size = new Size(231, 31);
            o_val.TabIndex = 53;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 70, 60);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Linen;
            textBox3.Location = new Point(12, 336);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 31);
            textBox3.TabIndex = 52;
            textBox3.Text = "Order Value";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(0, 70, 60);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.FromArgb(255, 201, 134);
            textBox8.Location = new Point(441, 336);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(43, 31);
            textBox8.TabIndex = 54;
            textBox8.Text = "£";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(255, 201, 134);
            checkBox1.Location = new Point(204, 80);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 26);
            checkBox1.TabIndex = 55;
            checkBox1.Text = "New Client ?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // clientid
            // 
            clientid.FormattingEnabled = true;
            clientid.Location = new Point(204, 112);
            clientid.Name = "clientid";
            clientid.Size = new Size(231, 33);
            clientid.TabIndex = 57;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 70, 60);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Linen;
            textBox2.Location = new Point(12, 114);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 31);
            textBox2.TabIndex = 56;
            textBox2.Text = "Client Code";
            // 
            // order_date
            // 
            order_date.Location = new Point(204, 373);
            order_date.Name = "order_date";
            order_date.Size = new Size(231, 31);
            order_date.TabIndex = 58;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(0, 70, 60);
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox10.ForeColor = Color.Linen;
            textBox10.Location = new Point(12, 373);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(186, 31);
            textBox10.TabIndex = 59;
            textBox10.Text = "Order Date";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(0, 70, 60);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox11.ForeColor = Color.FromArgb(255, 201, 134);
            textBox11.Location = new Point(441, 112);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(43, 31);
            textBox11.TabIndex = 60;
            textBox11.Text = "*";
            // 
            // AddClientOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 60);
            ClientSize = new Size(602, 476);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(order_date);
            Controls.Add(clientid);
            Controls.Add(textBox2);
            Controls.Add(checkBox1);
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
            ForeColor = Color.FromArgb(0, 70, 60);
            Name = "AddClientOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Client Order";
            Load += AddClientOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox p_code;
        private TextBox textBox16;
        private TextBox textBox9;
        private TextBox Instruction_txt;
        private TextBox textBox1;
        public TextBox p_name;
        private TextBox textBox21;
        public TextBox qty;
        private TextBox textBox4;
        public TextBox s_qty;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button addValues;
        private Button CloseButton;
        public TextBox category;
        private TextBox textBox7;
        public TextBox o_val;
        private TextBox textBox3;
        private TextBox textBox8;
        private CheckBox checkBox1;
        public ComboBox clientid;
        private TextBox textBox2;
        public DateTimePicker order_date;
        private TextBox textBox10;
        private TextBox textBox11;
    }
}