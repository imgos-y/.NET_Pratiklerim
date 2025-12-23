using System.ComponentModel;

namespace HealthcareScheduler;

partial class Doctor
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dgvDoctors = new System.Windows.Forms.DataGridView();
        txtDoctorName = new System.Windows.Forms.TextBox();
        txtSpecialization = new System.Windows.Forms.TextBox();
        btnAddDoctor = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        cmbDoctors = new System.Windows.Forms.ComboBox();
        dtpDate = new System.Windows.Forms.DateTimePicker();
        dtpStartTime = new System.Windows.Forms.DateTimePicker();
        dtpEndTime = new System.Windows.Forms.DateTimePicker();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        btnAddAvailability = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
        SuspendLayout();
        // 
        // dgvDoctors
        // 
        dgvDoctors.ColumnHeadersHeight = 29;
        dgvDoctors.Location = new System.Drawing.Point(1, 1);
        dgvDoctors.Name = "dgvDoctors";
        dgvDoctors.RowHeadersWidth = 51;
        dgvDoctors.Size = new System.Drawing.Size(572, 152);
        dgvDoctors.TabIndex = 0;
        dgvDoctors.CellContentClick += dgvDoctors_CellContentClick;
        // 
        // txtDoctorName
        // 
        txtDoctorName.Location = new System.Drawing.Point(37, 196);
        txtDoctorName.Name = "txtDoctorName";
        txtDoctorName.Size = new System.Drawing.Size(247, 27);
        txtDoctorName.TabIndex = 1;
        // 
        // txtSpecialization
        // 
        txtSpecialization.Location = new System.Drawing.Point(37, 267);
        txtSpecialization.Name = "txtSpecialization";
        txtSpecialization.Size = new System.Drawing.Size(247, 27);
        txtSpecialization.TabIndex = 2;
        // 
        // btnAddDoctor
        // 
        btnAddDoctor.ForeColor = System.Drawing.Color.Red;
        btnAddDoctor.Location = new System.Drawing.Point(96, 310);
        btnAddDoctor.Name = "btnAddDoctor";
        btnAddDoctor.Size = new System.Drawing.Size(97, 38);
        btnAddDoctor.TabIndex = 3;
        btnAddDoctor.Text = "Add Doctor";
        btnAddDoctor.UseVisualStyleBackColor = true;
        btnAddDoctor.Click += btnAddDoctor_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(37, 170);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 4;
        label1.Text = "Name";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(37, 241);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(115, 23);
        label2.TabIndex = 5;
        label2.Text = "Specialization";
        // 
        // cmbDoctors
        // 
        cmbDoctors.FormattingEnabled = true;
        cmbDoctors.Location = new System.Drawing.Point(498, 170);
        cmbDoctors.Name = "cmbDoctors";
        cmbDoctors.Size = new System.Drawing.Size(121, 28);
        cmbDoctors.TabIndex = 6;
        // 
        // dtpDate
        // 
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDate.Location = new System.Drawing.Point(467, 241);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new System.Drawing.Size(200, 27);
        dtpDate.TabIndex = 7;
        // 
        // dtpStartTime
        // 
        dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        dtpStartTime.Location = new System.Drawing.Point(344, 314);
        dtpStartTime.Name = "dtpStartTime";
        dtpStartTime.ShowUpDown = true;
        dtpStartTime.Size = new System.Drawing.Size(200, 27);
        dtpStartTime.TabIndex = 8;
        // 
        // dtpEndTime
        // 
        dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        dtpEndTime.Location = new System.Drawing.Point(588, 314);
        dtpEndTime.Name = "dtpEndTime";
        dtpEndTime.ShowUpDown = true;
        dtpEndTime.Size = new System.Drawing.Size(200, 27);
        dtpEndTime.TabIndex = 9;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(344, 288);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(128, 23);
        label3.TabIndex = 10;
        label3.Text = "Availability Start";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(586, 288);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(144, 23);
        label4.TabIndex = 11;
        label4.Text = "Availability End";
        // 
        // btnAddAvailability
        // 
        btnAddAvailability.ForeColor = System.Drawing.Color.Red;
        btnAddAvailability.Location = new System.Drawing.Point(498, 360);
        btnAddAvailability.Name = "btnAddAvailability";
        btnAddAvailability.Size = new System.Drawing.Size(169, 48);
        btnAddAvailability.TabIndex = 12;
        btnAddAvailability.Text = "Add Availability";
        btnAddAvailability.UseVisualStyleBackColor = true;
        // 
        // Doctor
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnAddAvailability);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(dtpEndTime);
        Controls.Add(dtpStartTime);
        Controls.Add(dtpDate);
        Controls.Add(cmbDoctors);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnAddDoctor);
        Controls.Add(txtSpecialization);
        Controls.Add(txtDoctorName);
        Controls.Add(dgvDoctors);
        Text = "Doctor";
        ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnAddAvailability;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.DateTimePicker dtpEndTime;

    private System.Windows.Forms.DateTimePicker dtpStartTime;

    private System.Windows.Forms.DateTimePicker dtpDate;

    private System.Windows.Forms.ComboBox cmbDoctors;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox txtDoctorName;
    private System.Windows.Forms.TextBox txtSpecialization;
    private System.Windows.Forms.Button btnAddDoctor;

    private System.Windows.Forms.DataGridView dgvDoctors;

    #endregion
}