namespace ACOTIN_POS_APPLICATION
{
    partial class Activity3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.discountTxtBox = new System.Windows.Forms.TextBox();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.A_ChickenMcDoBox = new System.Windows.Forms.CheckBox();
            this.A_BFFFriesBox = new System.Windows.Forms.CheckBox();
            this.A_DrinksBox = new System.Windows.Forms.CheckBox();
            this.A_RiceBox = new System.Windows.Forms.CheckBox();
            this.B_QuarterPounderBox = new System.Windows.Forms.CheckBox();
            this.B_ChickenSandwichBox = new System.Windows.Forms.CheckBox();
            this.B_BFFFriesBox = new System.Windows.Forms.CheckBox();
            this.B_ApplePieBox = new System.Windows.Forms.CheckBox();
            this.B_BurgerMcDoBox = new System.Windows.Forms.CheckBox();
            this.foodARdbtn = new System.Windows.Forms.RadioButton();
            this.foodBRdbtn = new System.Windows.Forms.RadioButton();
            this.DisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(106, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "MCDONALD\'S CORP. FOOD ORDERING APPLICATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foodBRdbtn);
            this.groupBox1.Controls.Add(this.foodARdbtn);
            this.groupBox1.Location = new System.Drawing.Point(74, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Order Choices";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.A_RiceBox);
            this.groupBox2.Controls.Add(this.A_DrinksBox);
            this.groupBox2.Controls.Add(this.A_BFFFriesBox);
            this.groupBox2.Controls.Add(this.A_ChickenMcDoBox);
            this.groupBox2.Location = new System.Drawing.Point(469, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 293);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "McShare Bundle for 3";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.DisplayPictureBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.priceTxtBox);
            this.groupBox3.Controls.Add(this.discountTxtBox);
            this.groupBox3.Location = new System.Drawing.Point(74, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 451);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Details";
            // 
            // discountTxtBox
            // 
            this.discountTxtBox.Location = new System.Drawing.Point(109, 74);
            this.discountTxtBox.Name = "discountTxtBox";
            this.discountTxtBox.Size = new System.Drawing.Size(212, 20);
            this.discountTxtBox.TabIndex = 0;
            this.discountTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(109, 40);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(212, 20);
            this.priceTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order Image:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(188, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 73);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.B_BurgerMcDoBox);
            this.groupBox4.Controls.Add(this.B_QuarterPounderBox);
            this.groupBox4.Controls.Add(this.B_ChickenSandwichBox);
            this.groupBox4.Controls.Add(this.B_ApplePieBox);
            this.groupBox4.Controls.Add(this.B_BFFFriesBox);
            this.groupBox4.Location = new System.Drawing.Point(469, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 293);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Snack Burger McShare";
            // 
            // A_ChickenMcDoBox
            // 
            this.A_ChickenMcDoBox.AutoSize = true;
            this.A_ChickenMcDoBox.Location = new System.Drawing.Point(34, 38);
            this.A_ChickenMcDoBox.Name = "A_ChickenMcDoBox";
            this.A_ChickenMcDoBox.Size = new System.Drawing.Size(129, 17);
            this.A_ChickenMcDoBox.TabIndex = 2;
            this.A_ChickenMcDoBox.Text = "6 pcs. Chicken McDo";
            this.A_ChickenMcDoBox.UseVisualStyleBackColor = true;
            // 
            // A_BFFFriesBox
            // 
            this.A_BFFFriesBox.AutoSize = true;
            this.A_BFFFriesBox.Location = new System.Drawing.Point(34, 88);
            this.A_BFFFriesBox.Name = "A_BFFFriesBox";
            this.A_BFFFriesBox.Size = new System.Drawing.Size(111, 17);
            this.A_BFFFriesBox.TabIndex = 3;
            this.A_BFFFriesBox.Text = "1 McDo BFF Fries";
            this.A_BFFFriesBox.UseVisualStyleBackColor = true;
            this.A_BFFFriesBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // A_DrinksBox
            // 
            this.A_DrinksBox.AutoSize = true;
            this.A_DrinksBox.Location = new System.Drawing.Point(34, 138);
            this.A_DrinksBox.Name = "A_DrinksBox";
            this.A_DrinksBox.Size = new System.Drawing.Size(128, 17);
            this.A_DrinksBox.TabIndex = 4;
            this.A_DrinksBox.Text = "3 Medium Size Drinks";
            this.A_DrinksBox.UseVisualStyleBackColor = true;
            this.A_DrinksBox.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // A_RiceBox
            // 
            this.A_RiceBox.AutoSize = true;
            this.A_RiceBox.Location = new System.Drawing.Point(34, 188);
            this.A_RiceBox.Name = "A_RiceBox";
            this.A_RiceBox.Size = new System.Drawing.Size(80, 17);
            this.A_RiceBox.TabIndex = 5;
            this.A_RiceBox.Text = "3 pcs. Rice";
            this.A_RiceBox.UseVisualStyleBackColor = true;
            // 
            // B_QuarterPounderBox
            // 
            this.B_QuarterPounderBox.AutoSize = true;
            this.B_QuarterPounderBox.Location = new System.Drawing.Point(34, 192);
            this.B_QuarterPounderBox.Name = "B_QuarterPounderBox";
            this.B_QuarterPounderBox.Size = new System.Drawing.Size(131, 17);
            this.B_QuarterPounderBox.TabIndex = 9;
            this.B_QuarterPounderBox.Text = "1 pc. Quarter Pounder";
            this.B_QuarterPounderBox.UseVisualStyleBackColor = true;
            // 
            // B_ChickenSandwichBox
            // 
            this.B_ChickenSandwichBox.AutoSize = true;
            this.B_ChickenSandwichBox.Location = new System.Drawing.Point(34, 142);
            this.B_ChickenSandwichBox.Name = "B_ChickenSandwichBox";
            this.B_ChickenSandwichBox.Size = new System.Drawing.Size(155, 17);
            this.B_ChickenSandwichBox.TabIndex = 8;
            this.B_ChickenSandwichBox.Text = "1 Crispy Chicken Sandwich";
            this.B_ChickenSandwichBox.UseVisualStyleBackColor = true;
            // 
            // B_BFFFriesBox
            // 
            this.B_BFFFriesBox.AutoSize = true;
            this.B_BFFFriesBox.Location = new System.Drawing.Point(34, 92);
            this.B_BFFFriesBox.Name = "B_BFFFriesBox";
            this.B_BFFFriesBox.Size = new System.Drawing.Size(111, 17);
            this.B_BFFFriesBox.TabIndex = 7;
            this.B_BFFFriesBox.Text = "1 McDo BFF Fries";
            this.B_BFFFriesBox.UseVisualStyleBackColor = true;
            // 
            // B_ApplePieBox
            // 
            this.B_ApplePieBox.AutoSize = true;
            this.B_ApplePieBox.Location = new System.Drawing.Point(34, 42);
            this.B_ApplePieBox.Name = "B_ApplePieBox";
            this.B_ApplePieBox.Size = new System.Drawing.Size(135, 17);
            this.B_ApplePieBox.TabIndex = 6;
            this.B_ApplePieBox.Text = "3 pcs. McDo Apple Pie";
            this.B_ApplePieBox.UseVisualStyleBackColor = true;
            // 
            // B_BurgerMcDoBox
            // 
            this.B_BurgerMcDoBox.AutoSize = true;
            this.B_BurgerMcDoBox.Location = new System.Drawing.Point(34, 242);
            this.B_BurgerMcDoBox.Name = "B_BurgerMcDoBox";
            this.B_BurgerMcDoBox.Size = new System.Drawing.Size(116, 17);
            this.B_BurgerMcDoBox.TabIndex = 10;
            this.B_BurgerMcDoBox.Text = "1 pc. Burger McDo";
            this.B_BurgerMcDoBox.UseVisualStyleBackColor = true;
            // 
            // foodARdbtn
            // 
            this.foodARdbtn.AutoSize = true;
            this.foodARdbtn.Location = new System.Drawing.Point(30, 37);
            this.foodARdbtn.Name = "foodARdbtn";
            this.foodARdbtn.Size = new System.Drawing.Size(128, 17);
            this.foodARdbtn.TabIndex = 2;
            this.foodARdbtn.TabStop = true;
            this.foodARdbtn.Text = "McShare Bundle for 3";
            this.foodARdbtn.UseVisualStyleBackColor = true;
            this.foodARdbtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // foodBRdbtn
            // 
            this.foodBRdbtn.AutoSize = true;
            this.foodBRdbtn.Location = new System.Drawing.Point(30, 87);
            this.foodBRdbtn.Name = "foodBRdbtn";
            this.foodBRdbtn.Size = new System.Drawing.Size(136, 17);
            this.foodBRdbtn.TabIndex = 3;
            this.foodBRdbtn.TabStop = true;
            this.foodBRdbtn.Text = "Snack Burger McShare";
            this.foodBRdbtn.UseVisualStyleBackColor = true;
            this.foodBRdbtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // DisplayPictureBox
            // 
            this.DisplayPictureBox.BackColor = System.Drawing.Color.White;
            this.DisplayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayPictureBox.Location = new System.Drawing.Point(109, 114);
            this.DisplayPictureBox.Name = "DisplayPictureBox";
            this.DisplayPictureBox.Size = new System.Drawing.Size(212, 212);
            this.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DisplayPictureBox.TabIndex = 5;
            this.DisplayPictureBox.TabStop = false;
            this.DisplayPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Activity3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(916, 744);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Activity3";
            this.Text = "Example 4";
            this.Load += new System.EventHandler(this.Activity3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox discountTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox DisplayPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox A_ChickenMcDoBox;
        private System.Windows.Forms.CheckBox A_DrinksBox;
        private System.Windows.Forms.CheckBox A_BFFFriesBox;
        private System.Windows.Forms.CheckBox A_RiceBox;
        private System.Windows.Forms.CheckBox B_QuarterPounderBox;
        private System.Windows.Forms.CheckBox B_ChickenSandwichBox;
        private System.Windows.Forms.CheckBox B_ApplePieBox;
        private System.Windows.Forms.CheckBox B_BFFFriesBox;
        private System.Windows.Forms.CheckBox B_BurgerMcDoBox;
        private System.Windows.Forms.RadioButton foodBRdbtn;
        private System.Windows.Forms.RadioButton foodARdbtn;
    }
}