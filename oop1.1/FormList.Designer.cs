namespace oop1._1
{
    partial class FormList
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
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.buttonRemoveAt = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonContains = new System.Windows.Forms.Button();
            this.buttonIndexOf = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.buttonSubList = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonArrayList = new System.Windows.Forms.RadioButton();
            this.radioButtonLinkedList = new System.Windows.Forms.RadioButton();
            this.radioButtonUnmutableList = new System.Windows.Forms.RadioButton();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonInt = new System.Windows.Forms.RadioButton();
            this.radioButtonString = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelListType = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxToIndex = new System.Windows.Forms.TextBox();
            this.textBoxFromIndex = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxList
            // 
            this.textBoxList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxList.Location = new System.Drawing.Point(2, 23);
            this.textBoxList.Multiline = true;
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.ReadOnly = true;
            this.textBoxList.Size = new System.Drawing.Size(206, 432);
            this.textBoxList.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelValue);
            this.groupBox.Controls.Add(this.labelResult);
            this.groupBox.Controls.Add(this.labelIndex);
            this.groupBox.Controls.Add(this.buttonRemoveAt);
            this.groupBox.Controls.Add(this.buttonRemove);
            this.groupBox.Controls.Add(this.buttonInsert);
            this.groupBox.Controls.Add(this.buttonContains);
            this.groupBox.Controls.Add(this.buttonIndexOf);
            this.groupBox.Controls.Add(this.buttonAdd);
            this.groupBox.Controls.Add(this.textBoxValue);
            this.groupBox.Controls.Add(this.textBoxIndex);
            this.groupBox.Location = new System.Drawing.Point(214, 131);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(230, 213);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(20, 45);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(37, 13);
            this.labelValue.TabIndex = 24;
            this.labelValue.Text = "Value:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(100, 189);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 8;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(21, 19);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(36, 13);
            this.labelIndex.TabIndex = 23;
            this.labelIndex.Text = "Index:";
            // 
            // buttonRemoveAt
            // 
            this.buttonRemoveAt.Location = new System.Drawing.Point(130, 146);
            this.buttonRemoveAt.Name = "buttonRemoveAt";
            this.buttonRemoveAt.Size = new System.Drawing.Size(77, 33);
            this.buttonRemoveAt.TabIndex = 22;
            this.buttonRemoveAt.Text = "RemoveAt";
            this.buttonRemoveAt.UseVisualStyleBackColor = true;
            this.buttonRemoveAt.Click += new System.EventHandler(this.buttonRemoveAt_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(23, 146);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(77, 33);
            this.buttonRemove.TabIndex = 20;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(129, 68);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(77, 33);
            this.buttonInsert.TabIndex = 19;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonContains
            // 
            this.buttonContains.Location = new System.Drawing.Point(23, 107);
            this.buttonContains.Name = "buttonContains";
            this.buttonContains.Size = new System.Drawing.Size(77, 33);
            this.buttonContains.TabIndex = 18;
            this.buttonContains.Text = "Contains";
            this.buttonContains.UseVisualStyleBackColor = true;
            this.buttonContains.Click += new System.EventHandler(this.buttonContains_Click);
            // 
            // buttonIndexOf
            // 
            this.buttonIndexOf.Location = new System.Drawing.Point(129, 107);
            this.buttonIndexOf.Name = "buttonIndexOf";
            this.buttonIndexOf.Size = new System.Drawing.Size(77, 33);
            this.buttonIndexOf.TabIndex = 17;
            this.buttonIndexOf.Text = "Index of";
            this.buttonIndexOf.UseVisualStyleBackColor = true;
            this.buttonIndexOf.Click += new System.EventHandler(this.buttonIndexOf_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 68);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 33);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(74, 42);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(139, 20);
            this.textBoxValue.TabIndex = 1;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(74, 16);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(139, 20);
            this.textBoxIndex.TabIndex = 0;
            // 
            // buttonSubList
            // 
            this.buttonSubList.Location = new System.Drawing.Point(165, 19);
            this.buttonSubList.Name = "buttonSubList";
            this.buttonSubList.Size = new System.Drawing.Size(56, 32);
            this.buttonSubList.TabIndex = 21;
            this.buttonSubList.Text = "subList";
            this.buttonSubList.UseVisualStyleBackColor = true;
            this.buttonSubList.Click += new System.EventHandler(this.buttonSubList_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(295, 425);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(77, 32);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonArrayList
            // 
            this.radioButtonArrayList.AutoSize = true;
            this.radioButtonArrayList.Location = new System.Drawing.Point(6, 19);
            this.radioButtonArrayList.Name = "radioButtonArrayList";
            this.radioButtonArrayList.Size = new System.Drawing.Size(65, 17);
            this.radioButtonArrayList.TabIndex = 0;
            this.radioButtonArrayList.TabStop = true;
            this.radioButtonArrayList.Tag = "0";
            this.radioButtonArrayList.Text = "ArrayList";
            this.radioButtonArrayList.UseVisualStyleBackColor = true;
            this.radioButtonArrayList.CheckedChanged += new System.EventHandler(this.radioButtonListType);
            // 
            // radioButtonLinkedList
            // 
            this.radioButtonLinkedList.AutoSize = true;
            this.radioButtonLinkedList.Location = new System.Drawing.Point(6, 38);
            this.radioButtonLinkedList.Name = "radioButtonLinkedList";
            this.radioButtonLinkedList.Size = new System.Drawing.Size(73, 17);
            this.radioButtonLinkedList.TabIndex = 1;
            this.radioButtonLinkedList.TabStop = true;
            this.radioButtonLinkedList.Tag = "1";
            this.radioButtonLinkedList.Text = "LinkedList";
            this.radioButtonLinkedList.UseVisualStyleBackColor = true;
            this.radioButtonLinkedList.CheckedChanged += new System.EventHandler(this.radioButtonListType);
            // 
            // radioButtonUnmutableList
            // 
            this.radioButtonUnmutableList.AutoSize = true;
            this.radioButtonUnmutableList.Location = new System.Drawing.Point(6, 59);
            this.radioButtonUnmutableList.Name = "radioButtonUnmutableList";
            this.radioButtonUnmutableList.Size = new System.Drawing.Size(92, 17);
            this.radioButtonUnmutableList.TabIndex = 2;
            this.radioButtonUnmutableList.TabStop = true;
            this.radioButtonUnmutableList.Tag = "2";
            this.radioButtonUnmutableList.Text = "UnmutableList";
            this.radioButtonUnmutableList.UseVisualStyleBackColor = true;
            this.radioButtonUnmutableList.CheckedChanged += new System.EventHandler(this.radioButtonListType);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(288, 96);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(84, 29);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonInt);
            this.groupBox2.Controls.Add(this.radioButtonString);
            this.groupBox2.Location = new System.Drawing.Point(344, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data type";
            // 
            // radioButtonInt
            // 
            this.radioButtonInt.AutoSize = true;
            this.radioButtonInt.Location = new System.Drawing.Point(6, 42);
            this.radioButtonInt.Name = "radioButtonInt";
            this.radioButtonInt.Size = new System.Drawing.Size(36, 17);
            this.radioButtonInt.TabIndex = 5;
            this.radioButtonInt.TabStop = true;
            this.radioButtonInt.Tag = "4";
            this.radioButtonInt.Text = "int";
            this.radioButtonInt.UseVisualStyleBackColor = true;
            this.radioButtonInt.CheckedChanged += new System.EventHandler(this.radioButtonDataType);
            // 
            // radioButtonString
            // 
            this.radioButtonString.AutoSize = true;
            this.radioButtonString.Location = new System.Drawing.Point(6, 19);
            this.radioButtonString.Name = "radioButtonString";
            this.radioButtonString.Size = new System.Drawing.Size(50, 17);
            this.radioButtonString.TabIndex = 4;
            this.radioButtonString.TabStop = true;
            this.radioButtonString.Tag = "3";
            this.radioButtonString.Text = "string";
            this.radioButtonString.UseVisualStyleBackColor = true;
            this.radioButtonString.CheckedChanged += new System.EventHandler(this.radioButtonDataType);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonArrayList);
            this.groupBox3.Controls.Add(this.radioButtonLinkedList);
            this.groupBox3.Controls.Add(this.radioButtonUnmutableList);
            this.groupBox3.Location = new System.Drawing.Point(228, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List type";
            // 
            // labelListType
            // 
            this.labelListType.AutoSize = true;
            this.labelListType.Location = new System.Drawing.Point(12, 7);
            this.labelListType.Name = "labelListType";
            this.labelListType.Size = new System.Drawing.Size(0, 13);
            this.labelListType.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxToIndex);
            this.groupBox4.Controls.Add(this.textBoxFromIndex);
            this.groupBox4.Controls.Add(this.buttonSubList);
            this.groupBox4.Location = new System.Drawing.Point(214, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 69);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "From:";
            // 
            // textBoxToIndex
            // 
            this.textBoxToIndex.Location = new System.Drawing.Point(74, 43);
            this.textBoxToIndex.Name = "textBoxToIndex";
            this.textBoxToIndex.Size = new System.Drawing.Size(67, 20);
            this.textBoxToIndex.TabIndex = 23;
            // 
            // textBoxFromIndex
            // 
            this.textBoxFromIndex.Location = new System.Drawing.Point(74, 16);
            this.textBoxFromIndex.Name = "textBoxFromIndex";
            this.textBoxFromIndex.Size = new System.Drawing.Size(67, 20);
            this.textBoxFromIndex.TabIndex = 22;
            // 
            // panelControls
            // 
            this.panelControls.Location = new System.Drawing.Point(450, 2);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(209, 453);
            this.panelControls.TabIndex = 23;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 469);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelListType);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.buttonClear);
            this.MaximumSize = new System.Drawing.Size(682, 507);
            this.MinimumSize = new System.Drawing.Size(682, 507);
            this.Name = "FormList";
            this.Text = "List";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.RadioButton radioButtonArrayList;
        private System.Windows.Forms.RadioButton radioButtonLinkedList;
        private System.Windows.Forms.RadioButton radioButtonUnmutableList;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonInt;
        private System.Windows.Forms.RadioButton radioButtonString;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Button buttonRemoveAt;
        private System.Windows.Forms.Button buttonSubList;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonContains;
        private System.Windows.Forms.Button buttonIndexOf;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelListType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxToIndex;
        private System.Windows.Forms.TextBox textBoxFromIndex;
        private System.Windows.Forms.Panel panelControls;
    }
}

