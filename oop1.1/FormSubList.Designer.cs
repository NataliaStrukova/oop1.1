namespace oop1._1
{
    partial class FormSubList
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
            this.textBoxSubList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSubList
            // 
            this.textBoxSubList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubList.Location = new System.Drawing.Point(1, 1);
            this.textBoxSubList.Multiline = true;
            this.textBoxSubList.Name = "textBoxSubList";
            this.textBoxSubList.ReadOnly = true;
            this.textBoxSubList.Size = new System.Drawing.Size(193, 221);
            this.textBoxSubList.TabIndex = 0;
            // 
            // FormSubList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 222);
            this.Controls.Add(this.textBoxSubList);
            this.Name = "FormSubList";
            this.Text = "FormSubList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubList;
    }
}