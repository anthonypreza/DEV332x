namespace PrescriptionManager
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.byPatientTabPage = new System.Windows.Forms.TabPage();
            this.newPrescriptions = new System.Windows.Forms.Button();
            this.deletePrescriptions = new System.Windows.Forms.Button();
            this.repeatPrescriptions = new System.Windows.Forms.Button();
            this.prescriptionsGridView = new System.Windows.Forms.DataGridView();
            this.PrescriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label1 = new System.Windows.Forms.Label();
            this.patientsGridView = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.byDateTabPage = new System.Windows.Forms.TabPage();
            this.prescriptionsInPeriodGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.byPatientTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).BeginInit();
            this.byDateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionsInPeriodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.byPatientTabPage);
            this.tabControl1.Controls.Add(this.byDateTabPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // byPatientTabPage
            // 
            this.byPatientTabPage.Controls.Add(this.newPrescriptions);
            this.byPatientTabPage.Controls.Add(this.deletePrescriptions);
            this.byPatientTabPage.Controls.Add(this.repeatPrescriptions);
            this.byPatientTabPage.Controls.Add(this.prescriptionsGridView);
            this.byPatientTabPage.Controls.Add(this.Label1);
            this.byPatientTabPage.Controls.Add(this.patientsGridView);
            this.byPatientTabPage.Controls.Add(this.Label3);
            this.byPatientTabPage.Location = new System.Drawing.Point(4, 22);
            this.byPatientTabPage.Name = "byPatientTabPage";
            this.byPatientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.byPatientTabPage.Size = new System.Drawing.Size(587, 363);
            this.byPatientTabPage.TabIndex = 0;
            this.byPatientTabPage.Text = "View by Patient";
            this.byPatientTabPage.UseVisualStyleBackColor = true;
            // 
            // newPrescriptions
            // 
            this.newPrescriptions.Location = new System.Drawing.Point(455, 324);
            this.newPrescriptions.Name = "newPrescriptions";
            this.newPrescriptions.Size = new System.Drawing.Size(116, 23);
            this.newPrescriptions.TabIndex = 24;
            this.newPrescriptions.Text = "New Prescriptions";
            this.newPrescriptions.UseVisualStyleBackColor = true;
            this.newPrescriptions.Click += new System.EventHandler(this.newPrescriptions_Click);
            // 
            // deletePrescriptions
            // 
            this.deletePrescriptions.Location = new System.Drawing.Point(144, 324);
            this.deletePrescriptions.Name = "deletePrescriptions";
            this.deletePrescriptions.Size = new System.Drawing.Size(116, 23);
            this.deletePrescriptions.TabIndex = 23;
            this.deletePrescriptions.Text = "Delete Prescriptions";
            this.deletePrescriptions.UseVisualStyleBackColor = true;
            this.deletePrescriptions.Click += new System.EventHandler(this.deletePrescriptions_Click);
            // 
            // repeatPrescriptions
            // 
            this.repeatPrescriptions.Location = new System.Drawing.Point(18, 324);
            this.repeatPrescriptions.Name = "repeatPrescriptions";
            this.repeatPrescriptions.Size = new System.Drawing.Size(116, 23);
            this.repeatPrescriptions.TabIndex = 22;
            this.repeatPrescriptions.Text = "Repeat Prescriptions";
            this.repeatPrescriptions.UseVisualStyleBackColor = true;
            this.repeatPrescriptions.Click += new System.EventHandler(this.repeatPrescriptions_Click);
            // 
            // prescriptionsGridView
            // 
            this.prescriptionsGridView.AllowUserToAddRows = false;
            this.prescriptionsGridView.AllowUserToDeleteRows = false;
            this.prescriptionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrescriptionID,
            this.Description,
            this.Issued,
            this.RepeatCount});
            this.prescriptionsGridView.Location = new System.Drawing.Point(18, 164);
            this.prescriptionsGridView.Name = "prescriptionsGridView";
            this.prescriptionsGridView.ReadOnly = true;
            this.prescriptionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prescriptionsGridView.Size = new System.Drawing.Size(553, 146);
            this.prescriptionsGridView.TabIndex = 20;
            // 
            // PrescriptionID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrescriptionID.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrescriptionID.HeaderText = "ID";
            this.PrescriptionID.Name = "PrescriptionID";
            this.PrescriptionID.ReadOnly = true;
            this.PrescriptionID.Width = 33;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 250;
            // 
            // Issued
            // 
            this.Issued.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Issued.HeaderText = "Issued";
            this.Issued.Name = "Issued";
            this.Issued.ReadOnly = true;
            // 
            // RepeatCount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RepeatCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.RepeatCount.HeaderText = "Repeats";
            this.RepeatCount.Name = "RepeatCount";
            this.RepeatCount.ReadOnly = true;
            this.RepeatCount.Width = 50;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 13);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Patients:";
            // 
            // patientsGridView
            // 
            this.patientsGridView.AllowUserToAddRows = false;
            this.patientsGridView.AllowUserToDeleteRows = false;
            this.patientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.DoctorName});
            this.patientsGridView.Location = new System.Drawing.Point(15, 33);
            this.patientsGridView.Name = "patientsGridView";
            this.patientsGridView.ReadOnly = true;
            this.patientsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsGridView.Size = new System.Drawing.Size(556, 100);
            this.patientsGridView.TabIndex = 18;
            this.patientsGridView.SelectionChanged += new System.EventHandler(this.patientsGridView_SelectionChanged);
            // 
            // PatientID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PatientID.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientID.HeaderText = "ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 30;
            // 
            // DoctorName
            // 
            this.DoctorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorName.HeaderText = "Name";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(15, 148);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(163, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Prescriptions for selected patient:";
            // 
            // byDateTabPage
            // 
            this.byDateTabPage.Controls.Add(this.prescriptionsInPeriodGridView);
            this.byDateTabPage.Controls.Add(this.label5);
            this.byDateTabPage.Controls.Add(this.go);
            this.byDateTabPage.Controls.Add(this.toDatePicker);
            this.byDateTabPage.Controls.Add(this.label4);
            this.byDateTabPage.Controls.Add(this.fromDatePicker);
            this.byDateTabPage.Controls.Add(this.label2);
            this.byDateTabPage.Location = new System.Drawing.Point(4, 22);
            this.byDateTabPage.Name = "byDateTabPage";
            this.byDateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.byDateTabPage.Size = new System.Drawing.Size(587, 363);
            this.byDateTabPage.TabIndex = 1;
            this.byDateTabPage.Text = "View by Date";
            this.byDateTabPage.UseVisualStyleBackColor = true;
            // 
            // prescriptionsInPeriodGridView
            // 
            this.prescriptionsInPeriodGridView.AllowUserToAddRows = false;
            this.prescriptionsInPeriodGridView.AllowUserToDeleteRows = false;
            this.prescriptionsInPeriodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionsInPeriodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.PatientName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.prescriptionsInPeriodGridView.Location = new System.Drawing.Point(18, 75);
            this.prescriptionsInPeriodGridView.Name = "prescriptionsInPeriodGridView";
            this.prescriptionsInPeriodGridView.ReadOnly = true;
            this.prescriptionsInPeriodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prescriptionsInPeriodGridView.Size = new System.Drawing.Size(553, 272);
            this.prescriptionsInPeriodGridView.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prescriptions in specified date range:";
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(516, 18);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(55, 23);
            this.go.TabIndex = 4;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(302, 19);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(52, 19);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 33;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Issued";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Repeats";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Prescription Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.byPatientTabPage.ResumeLayout(false);
            this.byPatientTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).EndInit();
            this.byDateTabPage.ResumeLayout(false);
            this.byDateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionsInPeriodGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage byPatientTabPage;
        private System.Windows.Forms.TabPage byDateTabPage;
        internal System.Windows.Forms.DataGridView prescriptionsGridView;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView patientsGridView;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.Button repeatPrescriptions;
        private System.Windows.Forms.Button newPrescriptions;
        private System.Windows.Forms.Button deletePrescriptions;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView prescriptionsInPeriodGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

