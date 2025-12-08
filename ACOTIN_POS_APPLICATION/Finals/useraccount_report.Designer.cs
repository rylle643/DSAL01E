namespace ACOTIN_POS_APPLICATION
{
    partial class useraccount_report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.optionInputTxtbox = new System.Windows.Forms.TextBox();
            this.optionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1855, 958);
            this.dataGridView1.TabIndex = 17;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LavenderBlush;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1401, 16);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(111, 38);
            this.Back.TabIndex = 16;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.LavenderBlush;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1274, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(111, 38);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // optionInputTxtbox
            // 
            this.optionInputTxtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionInputTxtbox.Location = new System.Drawing.Point(712, 22);
            this.optionInputTxtbox.Name = "optionInputTxtbox";
            this.optionInputTxtbox.Size = new System.Drawing.Size(546, 27);
            this.optionInputTxtbox.TabIndex = 14;
            // 
            // optionCombo
            // 
            this.optionCombo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCombo.FormattingEnabled = true;
            this.optionCombo.Location = new System.Drawing.Point(149, 22);
            this.optionCombo.Name = "optionCombo";
            this.optionCombo.Size = new System.Drawing.Size(546, 28);
            this.optionCombo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select an option:";
            // 
            // useraccount_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.optionInputTxtbox);
            this.Controls.Add(this.optionCombo);
            this.Controls.Add(this.label1);
            this.Name = "useraccount_report";
            this.Text = "sales_reports";
            this.Load += new System.EventHandler(this.sales_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox optionInputTxtbox;
        private System.Windows.Forms.ComboBox optionCombo;
        private System.Windows.Forms.Label label1;
    }
}