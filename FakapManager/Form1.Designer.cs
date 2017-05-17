namespace FakapManager
{
    partial class Form1
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
            this.tcCheck = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbRegEntry = new System.Windows.Forms.TextBox();
            this.lblKeyValue = new System.Windows.Forms.Label();
            this.btnCheckVal = new System.Windows.Forms.Button();
            this.lblRegKey = new System.Windows.Forms.Label();
            this.txtbRegKey = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValueUpdate = new System.Windows.Forms.TextBox();
            this.txtbValueName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnKronosSet = new System.Windows.Forms.Button();
            this.KronosPath2 = new System.Windows.Forms.TextBox();
            this.KronosPath1 = new System.Windows.Forms.TextBox();
            this.KronosDBName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDir1 = new System.Windows.Forms.Label();
            this.lblDBName = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtbValName = new System.Windows.Forms.TextBox();
            this.txtbSubKey = new System.Windows.Forms.TextBox();
            this.cmbRoots = new System.Windows.Forms.ComboBox();
            this.lblKronosErr = new System.Windows.Forms.Label();
            this.tcCheck.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCheck
            // 
            this.tcCheck.Controls.Add(this.tabPage1);
            this.tcCheck.Controls.Add(this.tabPage2);
            this.tcCheck.Controls.Add(this.tabPage3);
            this.tcCheck.Controls.Add(this.tabPage4);
            this.tcCheck.Location = new System.Drawing.Point(13, 4);
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.SelectedIndex = 0;
            this.tcCheck.Size = new System.Drawing.Size(477, 399);
            this.tcCheck.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtbRegEntry);
            this.tabPage1.Controls.Add(this.lblKeyValue);
            this.tabPage1.Controls.Add(this.btnCheckVal);
            this.tabPage1.Controls.Add(this.lblRegKey);
            this.tabPage1.Controls.Add(this.txtbRegKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CheckValue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Klucz";
            // 
            // txtbRegEntry
            // 
            this.txtbRegEntry.Location = new System.Drawing.Point(9, 154);
            this.txtbRegEntry.Name = "txtbRegEntry";
            this.txtbRegEntry.Size = new System.Drawing.Size(100, 20);
            this.txtbRegEntry.TabIndex = 4;
            // 
            // lblKeyValue
            // 
            this.lblKeyValue.AutoSize = true;
            this.lblKeyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKeyValue.Location = new System.Drawing.Point(4, 271);
            this.lblKeyValue.Name = "lblKeyValue";
            this.lblKeyValue.Size = new System.Drawing.Size(39, 20);
            this.lblKeyValue.TabIndex = 3;
            this.lblKeyValue.Text = "Null";
            // 
            // btnCheckVal
            // 
            this.btnCheckVal.Location = new System.Drawing.Point(376, 194);
            this.btnCheckVal.Name = "btnCheckVal";
            this.btnCheckVal.Size = new System.Drawing.Size(75, 23);
            this.btnCheckVal.TabIndex = 2;
            this.btnCheckVal.Text = "Check";
            this.btnCheckVal.UseVisualStyleBackColor = true;
            this.btnCheckVal.Click += new System.EventHandler(this.btnCheckVal_Click);
            // 
            // lblRegKey
            // 
            this.lblRegKey.AutoSize = true;
            this.lblRegKey.Location = new System.Drawing.Point(6, 23);
            this.lblRegKey.Name = "lblRegKey";
            this.lblRegKey.Size = new System.Drawing.Size(75, 13);
            this.lblRegKey.TabIndex = 1;
            this.lblRegKey.Text = "Klucz Rejestru";
            // 
            // txtbRegKey
            // 
            this.txtbRegKey.Location = new System.Drawing.Point(7, 78);
            this.txtbRegKey.Name = "txtbRegKey";
            this.txtbRegKey.Size = new System.Drawing.Size(444, 20);
            this.txtbRegKey.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtValueUpdate);
            this.tabPage2.Controls.Add(this.txtbValueName);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.txtBoxKey);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UpdateValue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ValueName";
            // 
            // txtValueUpdate
            // 
            this.txtValueUpdate.Location = new System.Drawing.Point(105, 85);
            this.txtValueUpdate.Name = "txtValueUpdate";
            this.txtValueUpdate.Size = new System.Drawing.Size(272, 20);
            this.txtValueUpdate.TabIndex = 4;
            // 
            // txtbValueName
            // 
            this.txtbValueName.Location = new System.Drawing.Point(105, 49);
            this.txtbValueName.Name = "txtbValueName";
            this.txtbValueName.Size = new System.Drawing.Size(272, 20);
            this.txtbValueName.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(302, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(105, 14);
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(272, 20);
            this.txtBoxKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblKronosErr);
            this.tabPage3.Controls.Add(this.btnKronosSet);
            this.tabPage3.Controls.Add(this.KronosPath2);
            this.tabPage3.Controls.Add(this.KronosPath1);
            this.tabPage3.Controls.Add(this.KronosDBName);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lblDir1);
            this.tabPage3.Controls.Add(this.lblDBName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(469, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "KRONOS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnKronosSet
            // 
            this.btnKronosSet.Location = new System.Drawing.Point(344, 293);
            this.btnKronosSet.Name = "btnKronosSet";
            this.btnKronosSet.Size = new System.Drawing.Size(75, 23);
            this.btnKronosSet.TabIndex = 7;
            this.btnKronosSet.Text = "Set";
            this.btnKronosSet.UseVisualStyleBackColor = true;
            this.btnKronosSet.Click += new System.EventHandler(this.btnKronosSet_Click);
            // 
            // KronosPath2
            // 
            this.KronosPath2.Location = new System.Drawing.Point(189, 187);
            this.KronosPath2.Name = "KronosPath2";
            this.KronosPath2.Size = new System.Drawing.Size(215, 20);
            this.KronosPath2.TabIndex = 6;
            this.KronosPath2.Text = "C:\\KronosNET3\\";
            // 
            // KronosPath1
            // 
            this.KronosPath1.Location = new System.Drawing.Point(189, 107);
            this.KronosPath1.Name = "KronosPath1";
            this.KronosPath1.Size = new System.Drawing.Size(215, 20);
            this.KronosPath1.TabIndex = 5;
            this.KronosPath1.Text = "C:\\KronosNET3\\";
            // 
            // KronosDBName
            // 
            this.KronosDBName.Location = new System.Drawing.Point(189, 27);
            this.KronosDBName.Name = "KronosDBName";
            this.KronosDBName.Size = new System.Drawing.Size(215, 20);
            this.KronosDBName.TabIndex = 4;
            this.KronosDBName.Text = "KronosNET30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ścieżka PathData";
            // 
            // lblDir1
            // 
            this.lblDir1.AutoSize = true;
            this.lblDir1.Location = new System.Drawing.Point(23, 114);
            this.lblDir1.Name = "lblDir1";
            this.lblDir1.Size = new System.Drawing.Size(129, 13);
            this.lblDir1.TabIndex = 2;
            this.lblDir1.Text = "Ścieżka do kronosa(Path)";
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(23, 34);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(66, 13);
            this.lblDBName.TabIndex = 1;
            this.lblDBName.Text = "Nazwa Bazy";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.lblResult);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btnDelete);
            this.tabPage4.Controls.Add(this.txtbValName);
            this.tabPage4.Controls.Add(this.txtbSubKey);
            this.tabPage4.Controls.Add(this.cmbRoots);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(469, 373);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DeleteValue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "To MUSI być Subkey inaczej pokaże, że brak wpisu, mimo, że istnieje";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(22, 233);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(10, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Registry SUB Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "KeyValue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Root:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Value";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtbValName
            // 
            this.txtbValName.Location = new System.Drawing.Point(160, 121);
            this.txtbValName.Name = "txtbValName";
            this.txtbValName.Size = new System.Drawing.Size(121, 20);
            this.txtbValName.TabIndex = 2;
            // 
            // txtbSubKey
            // 
            this.txtbSubKey.Location = new System.Drawing.Point(160, 59);
            this.txtbSubKey.Name = "txtbSubKey";
            this.txtbSubKey.Size = new System.Drawing.Size(291, 20);
            this.txtbSubKey.TabIndex = 1;
            // 
            // cmbRoots
            // 
            this.cmbRoots.FormattingEnabled = true;
            this.cmbRoots.Items.AddRange(new object[] {
            "Current User",
            "Local Machine"});
            this.cmbRoots.Location = new System.Drawing.Point(22, 58);
            this.cmbRoots.Name = "cmbRoots";
            this.cmbRoots.Size = new System.Drawing.Size(121, 21);
            this.cmbRoots.TabIndex = 0;
            // 
            // lblKronosErr
            // 
            this.lblKronosErr.AutoSize = true;
            this.lblKronosErr.Location = new System.Drawing.Point(26, 293);
            this.lblKronosErr.Name = "lblKronosErr";
            this.lblKronosErr.Size = new System.Drawing.Size(10, 13);
            this.lblKronosErr.TabIndex = 8;
            this.lblKronosErr.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 415);
            this.Controls.Add(this.tcCheck);
            this.Name = "Form1";
            this.Text = "FakapManager";
            this.tcCheck.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCheck;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblKeyValue;
        private System.Windows.Forms.Button btnCheckVal;
        private System.Windows.Forms.Label lblRegKey;
        private System.Windows.Forms.TextBox txtbRegKey;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtbRegEntry;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValueUpdate;
        private System.Windows.Forms.TextBox txtbValueName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDir1;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.Button btnKronosSet;
        private System.Windows.Forms.TextBox KronosPath2;
        private System.Windows.Forms.TextBox KronosPath1;
        private System.Windows.Forms.TextBox KronosDBName;
        private System.Windows.Forms.ComboBox cmbRoots;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtbValName;
        private System.Windows.Forms.TextBox txtbSubKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKronosErr;
    }
}

