using System.ComponentModel;

namespace HealthcareScheduler;

partial class Appointment
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
        monthCalendar1 = new System.Windows.Forms.MonthCalendar();
        cmbDoctors = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        cmbPatients = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        txtReason = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        cmbStatus = new System.Windows.Forms.ComboBox();
        label4 = new System.Windows.Forms.Label();
        btnAddAppointment = new System.Windows.Forms.Button();
        dgvAppointments = new System.Windows.Forms.DataGridView();
        lblReminder = new System.Windows.Forms.Label();
        dtpTime = new System.Windows.Forms.DateTimePicker();
        cmbFilterDoctor = new System.Windows.Forms.ComboBox();
        cmbFilterPatients = new System.Windows.Forms.ComboBox();
        cmbFilterStatus = new System.Windows.Forms.ComboBox();
        btnFilter = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
        SuspendLayout();
        // 
        // monthCalendar1
        // 
        monthCalendar1.Location = new System.Drawing.Point(8, 18);
        monthCalendar1.MaxSelectionCount = 1;
        monthCalendar1.Name = "monthCalendar1";
        monthCalendar1.TabIndex = 0;
        // 
        // cmbDoctors
        // 
        cmbDoctors.FormattingEnabled = true;
        cmbDoctors.Location = new System.Drawing.Point(470, 294);
        cmbDoctors.Name = "cmbDoctors";
        cmbDoctors.Size = new System.Drawing.Size(121, 28);
        cmbDoctors.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(459, 254);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(67, 22);
        label1.TabIndex = 2;
        label1.Text = "Doctors";
        // 
        // cmbPatients
        // 
        cmbPatients.FormattingEnabled = true;
        cmbPatients.Location = new System.Drawing.Point(653, 294);
        cmbPatients.Name = "cmbPatients";
        cmbPatients.Size = new System.Drawing.Size(119, 28);
        cmbPatients.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(653, 254);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(79, 22);
        label2.TabIndex = 4;
        label2.Text = "Patients";
        // 
        // txtReason
        // 
        txtReason.Location = new System.Drawing.Point(410, 350);
        txtReason.Multiline = true;
        txtReason.Name = "txtReason";
        txtReason.Size = new System.Drawing.Size(364, 111);
        txtReason.TabIndex = 5;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(410, 324);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 6;
        label3.Text = "Reason";
        // 
        // cmbStatus
        // 
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Completed", "Cancelled" });
        cmbStatus.Location = new System.Drawing.Point(501, 531);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new System.Drawing.Size(121, 28);
        cmbStatus.TabIndex = 7;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(388, 531);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(96, 24);
        label4.TabIndex = 8;
        label4.Text = "Status";
        // 
        // btnAddAppointment
        // 
        btnAddAppointment.Location = new System.Drawing.Point(653, 531);
        btnAddAppointment.Name = "btnAddAppointment";
        btnAddAppointment.Size = new System.Drawing.Size(121, 69);
        btnAddAppointment.TabIndex = 9;
        btnAddAppointment.Text = "Add Appointment";
        btnAddAppointment.UseVisualStyleBackColor = true;
        btnAddAppointment.Click += btnAddAppointment_Click;
        // 
        // dgvAppointments
        // 
        dgvAppointments.AllowUserToAddRows = false;
        dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvAppointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
        dgvAppointments.ColumnHeadersHeight = 29;
        dgvAppointments.Location = new System.Drawing.Point(12, 645);
        dgvAppointments.MultiSelect = false;
        dgvAppointments.Name = "dgvAppointments";
        dgvAppointments.ReadOnly = true;
        dgvAppointments.RowHeadersWidth = 51;
        dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvAppointments.Size = new System.Drawing.Size(776, 249);
        dgvAppointments.TabIndex = 10;
        // 
        // lblReminder
        // 
        lblReminder.AutoSize = true;
        lblReminder.ForeColor = System.Drawing.Color.Red;
        lblReminder.Location = new System.Drawing.Point(68, 302);
        lblReminder.Name = "lblReminder";
        lblReminder.Size = new System.Drawing.Size(0, 20);
        lblReminder.TabIndex = 11;
        // 
        // dtpTime
        // 
        dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        dtpTime.Location = new System.Drawing.Point(8, 249);
        dtpTime.Name = "dtpTime";
        dtpTime.ShowUpDown = true;
        dtpTime.Size = new System.Drawing.Size(200, 27);
        dtpTime.TabIndex = 12;
        dtpTime.ValueChanged += dtpTime_ValueChanged;
        // 
        // cmbFilterDoctor
        // 
        cmbFilterDoctor.FormattingEnabled = true;
        cmbFilterDoctor.Location = new System.Drawing.Point(322, 18);
        cmbFilterDoctor.Name = "cmbFilterDoctor";
        cmbFilterDoctor.Size = new System.Drawing.Size(129, 28);
        cmbFilterDoctor.TabIndex = 13;
        cmbFilterDoctor.Text = "All Doctors";
        // 
        // cmbFilterPatients
        // 
        cmbFilterPatients.FormattingEnabled = true;
        cmbFilterPatients.Location = new System.Drawing.Point(513, 18);
        cmbFilterPatients.Name = "cmbFilterPatients";
        cmbFilterPatients.Size = new System.Drawing.Size(129, 28);
        cmbFilterPatients.TabIndex = 14;
        cmbFilterPatients.Text = "All Patients";
        // 
        // cmbFilterStatus
        // 
        cmbFilterStatus.FormattingEnabled = true;
        cmbFilterStatus.Location = new System.Drawing.Point(697, 18);
        cmbFilterStatus.Name = "cmbFilterStatus";
        cmbFilterStatus.Size = new System.Drawing.Size(128, 28);
        cmbFilterStatus.TabIndex = 15;
        cmbFilterStatus.Text = "Status";
        // 
        // btnFilter
        // 
        btnFilter.ForeColor = System.Drawing.Color.Red;
        btnFilter.Location = new System.Drawing.Point(513, 104);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new System.Drawing.Size(125, 78);
        btnFilter.TabIndex = 16;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = true;
        btnFilter.Click += btnFilter_Click;
        // 
        // Appointment
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(962, 906);
        Controls.Add(btnFilter);
        Controls.Add(cmbFilterStatus);
        Controls.Add(cmbFilterPatients);
        Controls.Add(cmbFilterDoctor);
        Controls.Add(dtpTime);
        Controls.Add(lblReminder);
        Controls.Add(dgvAppointments);
        Controls.Add(btnAddAppointment);
        Controls.Add(label4);
        Controls.Add(cmbStatus);
        Controls.Add(label3);
        Controls.Add(txtReason);
        Controls.Add(label2);
        Controls.Add(cmbPatients);
        Controls.Add(label1);
        Controls.Add(cmbDoctors);
        Controls.Add(monthCalendar1);
        Text = "Appointment";
        ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox cmbFilterStatus;
    private System.Windows.Forms.Button btnFilter;

    private System.Windows.Forms.ComboBox cmbFilterDoctor;
    private System.Windows.Forms.ComboBox cmbFilterPatients;

    private System.Windows.Forms.DateTimePicker dtpTime;

    private System.Windows.Forms.Label lblReminder;

    private System.Windows.Forms.DataGridView dgvAppointments;

    private System.Windows.Forms.Button btnAddAppointment;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ComboBox cmbStatus;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox txtReason;

    private System.Windows.Forms.ComboBox cmbPatients;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox cmbDoctors;

    private System.Windows.Forms.MonthCalendar monthCalendar1;

    #endregion
}