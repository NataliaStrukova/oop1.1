namespace oop1._1
{
    partial class UserControlInt
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panelSort = new System.Windows.Forms.Panel();
            this.radioButtonDescending = new System.Windows.Forms.RadioButton();
            this.radioButtonAscending = new System.Windows.Forms.RadioButton();
            this.radioButtonAlph2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAlph1 = new System.Windows.Forms.RadioButton();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCheckRes = new System.Windows.Forms.Label();
            this.panelCheck = new System.Windows.Forms.Panel();
            this.textBoxDivisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheckForAll = new System.Windows.Forms.Button();
            this.buttonFindAll = new System.Windows.Forms.Button();
            this.buttonFindLastIndex = new System.Windows.Forms.Button();
            this.buttonFindIndex = new System.Windows.Forms.Button();
            this.buttonFindLast = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonExists = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.panelSort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panelSort);
            this.groupBox5.Controls.Add(this.buttonSort);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 128);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // panelSort
            // 
            this.panelSort.Controls.Add(this.radioButtonDescending);
            this.panelSort.Controls.Add(this.radioButtonAscending);
            this.panelSort.Controls.Add(this.radioButtonAlph2);
            this.panelSort.Controls.Add(this.radioButtonAlph1);
            this.panelSort.Location = new System.Drawing.Point(35, 17);
            this.panelSort.Name = "panelSort";
            this.panelSort.Size = new System.Drawing.Size(132, 58);
            this.panelSort.TabIndex = 10;
            // 
            // radioButtonDescending
            // 
            this.radioButtonDescending.AutoSize = true;
            this.radioButtonDescending.Location = new System.Drawing.Point(7, 32);
            this.radioButtonDescending.Name = "radioButtonDescending";
            this.radioButtonDescending.Size = new System.Drawing.Size(119, 17);
            this.radioButtonDescending.TabIndex = 5;
            this.radioButtonDescending.TabStop = true;
            this.radioButtonDescending.Tag = "-1";
            this.radioButtonDescending.Text = "In descending order";
            this.radioButtonDescending.UseVisualStyleBackColor = true;
            this.radioButtonDescending.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonAscending
            // 
            this.radioButtonAscending.AutoSize = true;
            this.radioButtonAscending.Location = new System.Drawing.Point(7, 9);
            this.radioButtonAscending.Name = "radioButtonAscending";
            this.radioButtonAscending.Size = new System.Drawing.Size(113, 17);
            this.radioButtonAscending.TabIndex = 4;
            this.radioButtonAscending.TabStop = true;
            this.radioButtonAscending.Tag = "1";
            this.radioButtonAscending.Text = "In ascending order";
            this.radioButtonAscending.UseVisualStyleBackColor = true;
            this.radioButtonAscending.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonAlph2
            // 
            this.radioButtonAlph2.AutoSize = true;
            this.radioButtonAlph2.Location = new System.Drawing.Point(15, 32);
            this.radioButtonAlph2.Name = "radioButtonAlph2";
            this.radioButtonAlph2.Size = new System.Drawing.Size(102, 17);
            this.radioButtonAlph2.TabIndex = 3;
            this.radioButtonAlph2.TabStop = true;
            this.radioButtonAlph2.Text = "Alphabetically↓";
            this.radioButtonAlph2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlph1
            // 
            this.radioButtonAlph1.AutoSize = true;
            this.radioButtonAlph1.Location = new System.Drawing.Point(15, 9);
            this.radioButtonAlph1.Name = "radioButtonAlph1";
            this.radioButtonAlph1.Size = new System.Drawing.Size(102, 17);
            this.radioButtonAlph1.TabIndex = 2;
            this.radioButtonAlph1.TabStop = true;
            this.radioButtonAlph1.Text = "Alphabetically↑";
            this.radioButtonAlph1.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(64, 81);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(78, 35);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCheckRes);
            this.groupBox1.Controls.Add(this.panelCheck);
            this.groupBox1.Controls.Add(this.buttonCheckForAll);
            this.groupBox1.Controls.Add(this.buttonFindAll);
            this.groupBox1.Controls.Add(this.buttonFindLastIndex);
            this.groupBox1.Controls.Add(this.buttonFindIndex);
            this.groupBox1.Controls.Add(this.buttonFindLast);
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.buttonExists);
            this.groupBox1.Location = new System.Drawing.Point(4, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 288);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // labelCheckRes
            // 
            this.labelCheckRes.AutoSize = true;
            this.labelCheckRes.Location = new System.Drawing.Point(112, 245);
            this.labelCheckRes.Name = "labelCheckRes";
            this.labelCheckRes.Size = new System.Drawing.Size(0, 13);
            this.labelCheckRes.TabIndex = 12;
            // 
            // panelCheck
            // 
            this.panelCheck.Controls.Add(this.textBoxDivisor);
            this.panelCheck.Controls.Add(this.label1);
            this.panelCheck.Location = new System.Drawing.Point(17, 16);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(166, 54);
            this.panelCheck.TabIndex = 11;
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.Location = new System.Drawing.Point(79, 17);
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.Size = new System.Drawing.Size(66, 20);
            this.textBoxDivisor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Divide by";
            // 
            // buttonCheckForAll
            // 
            this.buttonCheckForAll.Location = new System.Drawing.Point(103, 184);
            this.buttonCheckForAll.Name = "buttonCheckForAll";
            this.buttonCheckForAll.Size = new System.Drawing.Size(80, 35);
            this.buttonCheckForAll.TabIndex = 9;
            this.buttonCheckForAll.Text = "Check For All";
            this.buttonCheckForAll.UseVisualStyleBackColor = true;
            this.buttonCheckForAll.Click += new System.EventHandler(this.buttonCheckForAll_Click);
            // 
            // buttonFindAll
            // 
            this.buttonFindAll.Location = new System.Drawing.Point(17, 234);
            this.buttonFindAll.Name = "buttonFindAll";
            this.buttonFindAll.Size = new System.Drawing.Size(80, 35);
            this.buttonFindAll.TabIndex = 5;
            this.buttonFindAll.Text = "Find All";
            this.buttonFindAll.UseVisualStyleBackColor = true;
            this.buttonFindAll.Click += new System.EventHandler(this.buttonFindAll_Click);
            // 
            // buttonFindLastIndex
            // 
            this.buttonFindLastIndex.Location = new System.Drawing.Point(103, 84);
            this.buttonFindLastIndex.Name = "buttonFindLastIndex";
            this.buttonFindLastIndex.Size = new System.Drawing.Size(80, 35);
            this.buttonFindLastIndex.TabIndex = 4;
            this.buttonFindLastIndex.Text = "Find Last Index";
            this.buttonFindLastIndex.UseVisualStyleBackColor = true;
            this.buttonFindLastIndex.Click += new System.EventHandler(this.buttonFindLastIndex_Click);
            // 
            // buttonFindIndex
            // 
            this.buttonFindIndex.Location = new System.Drawing.Point(17, 184);
            this.buttonFindIndex.Name = "buttonFindIndex";
            this.buttonFindIndex.Size = new System.Drawing.Size(80, 35);
            this.buttonFindIndex.TabIndex = 3;
            this.buttonFindIndex.Text = "Find Index";
            this.buttonFindIndex.UseVisualStyleBackColor = true;
            this.buttonFindIndex.Click += new System.EventHandler(this.buttonFindIndex_Click);
            // 
            // buttonFindLast
            // 
            this.buttonFindLast.Location = new System.Drawing.Point(17, 134);
            this.buttonFindLast.Name = "buttonFindLast";
            this.buttonFindLast.Size = new System.Drawing.Size(80, 35);
            this.buttonFindLast.TabIndex = 2;
            this.buttonFindLast.Text = "Find Last";
            this.buttonFindLast.UseVisualStyleBackColor = true;
            this.buttonFindLast.Click += new System.EventHandler(this.buttonFindLast_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(17, 84);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(80, 35);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonExists
            // 
            this.buttonExists.Location = new System.Drawing.Point(103, 134);
            this.buttonExists.Name = "buttonExists";
            this.buttonExists.Size = new System.Drawing.Size(80, 35);
            this.buttonExists.TabIndex = 0;
            this.buttonExists.Text = "Exists";
            this.buttonExists.UseVisualStyleBackColor = true;
            this.buttonExists.Click += new System.EventHandler(this.buttonExists_Click);
            // 
            // UserControlInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlInt";
            this.Size = new System.Drawing.Size(209, 417);
            this.groupBox5.ResumeLayout(false);
            this.panelSort.ResumeLayout(false);
            this.panelSort.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.RadioButton radioButtonAlph2;
        private System.Windows.Forms.RadioButton radioButtonAlph1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCheckRes;
        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.Button buttonCheckForAll;
        private System.Windows.Forms.Button buttonFindAll;
        private System.Windows.Forms.Button buttonFindLastIndex;
        private System.Windows.Forms.Button buttonFindIndex;
        private System.Windows.Forms.Button buttonFindLast;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonExists;
        private System.Windows.Forms.TextBox textBoxDivisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDescending;
        private System.Windows.Forms.RadioButton radioButtonAscending;
    }
}
