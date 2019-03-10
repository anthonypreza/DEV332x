using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrescriptionManager
{
    public partial class NewPrescriptionsForm : Form
    {
        // Patient ID for whom new prescriptions will be added.
        private int _patientID;
        
        // Typed DataContext object.
        private ContosoMedicalDataClassesDataContext _db;

        public NewPrescriptionsForm(int patientID, ContosoMedicalDataClassesDataContext db)
        {
            InitializeComponent();

            // Store the patient ID.
            _patientID = patientID;
            Text = "New Prescriptions for PatientID " + patientID;

            // Store the typed DataContext object.
            _db = db;
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Create a Prescription entity.
            Prescription prescription = new Prescription()
            {
                PatientID = _patientID,
                IssueDate = issueDatePicker.Value.Date,
                Description = descriptionTextBox.Text,
                RepeatCount = 0
            };

            // Add the Prescription entity to the DataContext object.
            _db.Prescriptions.InsertOnSubmit(prescription);

            // Add the prescription description to addedPrescriptionsListBox.
            addedPrescriptionsListBox.Items.Add(prescription.Description);

            // Clear the description text box, ready for another prescription.
            descriptionTextBox.Clear();
            descriptionTextBox.Focus();
        }
    }
}
