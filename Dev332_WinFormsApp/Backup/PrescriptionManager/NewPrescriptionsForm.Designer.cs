namespace PrescriptionManager
{
    partial class NewPrescriptionsForm
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.issueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.add = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addedPrescriptionsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(80, 49);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(227, 46);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issue date";
            // 
            // issueDatePicker
            // 
            this.issueDatePicker.Location = new System.Drawing.Point(80, 12);
            this.issueDatePicker.Name = "issueDatePicker";
            this.issueDatePicker.Size = new System.Drawing.Size(227, 20);
            this.issueDatePicker.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(245, 101);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(62, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // done
            // 
            this.done.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.done.Location = new System.Drawing.Point(245, 258);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(62, 23);
            this.done.TabIndex = 5;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Added";
            // 
            // addedPrescriptionsListBox
            // 
            this.addedPrescriptionsListBox.FormattingEnabled = true;
            this.addedPrescriptionsListBox.Location = new System.Drawing.Point(80, 156);
            this.addedPrescriptionsListBox.Name = "addedPrescriptionsListBox";
            this.addedPrescriptionsListBox.Size = new System.Drawing.Size(227, 95);
            this.addedPrescriptionsListBox.TabIndex = 7;
            // 
            // NewPrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 293);
            this.Controls.Add(this.addedPrescriptionsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.done);
            this.Controls.Add(this.add);
            this.Controls.Add(this.issueDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPrescriptionsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Prescriptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker issueDatePicker;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox addedPrescriptionsListBox;
    }
}