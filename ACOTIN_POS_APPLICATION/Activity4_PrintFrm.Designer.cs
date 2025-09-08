namespace ACOTIN_POS_APPLICATION
{
    partial class Activity4_PrintFrm
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
            this.printDisplayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // printDisplayListbox
            // 
            this.printDisplayListbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDisplayListbox.FormattingEnabled = true;
            this.printDisplayListbox.ItemHeight = 17;
            this.printDisplayListbox.Location = new System.Drawing.Point(6, 13);
            this.printDisplayListbox.Name = "printDisplayListbox";
            this.printDisplayListbox.Size = new System.Drawing.Size(386, 446);
            this.printDisplayListbox.TabIndex = 10;
            this.printDisplayListbox.SelectedIndexChanged += new System.EventHandler(this.printDisplayListbox_SelectedIndexChanged);
            // 
            // Activity4_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 485);
            this.Controls.Add(this.printDisplayListbox);
            this.Name = "Activity4_PrintFrm";
            this.Text = "Activity4_PrintFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox printDisplayListbox;
    }
}