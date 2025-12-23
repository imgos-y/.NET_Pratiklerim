namespace HealthcareScheduler;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        TestButton = new System.Windows.Forms.Button();
        dgvPatient = new System.Windows.Forms.DataGridView();
        txtFirstName = new System.Windows.Forms.TextBox();
        txtLastName = new System.Windows.Forms.TextBox();
        txtEmail = new System.Windows.Forms.TextBox();
        dtpBirthDate = new System.Windows.Forms.DateTimePicker();
        btnAddPatient = new System.Windows.Forms.Button();
        txtPhone = new System.Windows.Forms.TextBox();
        btnUpdate = new System.Windows.Forms.Button();
        btnDelete = new System.Windows.Forms.Button();
        btnDoctors = new System.Windows.Forms.Button();
        btnAppointment = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dgvPatient).BeginInit();
        SuspendLayout();
        // 
        // TestButton
        // 
        TestButton.ForeColor = System.Drawing.SystemColors.HotTrack;
        TestButton.Location = new System.Drawing.Point(516, 560);
        TestButton.Name = "TestButton";
        TestButton.Size = new System.Drawing.Size(166, 105);
        TestButton.TabIndex = 0;
        TestButton.Text = "Database Connection Test\r\n";
        TestButton.UseVisualStyleBackColor = true;
        TestButton.Click += button1_Click_2;
        // 
        // dgvPatient
        // 
        dgvPatient.ColumnHeadersHeight = 29;
        dgvPatient.Dock = System.Windows.Forms.DockStyle.Top;
        dgvPatient.Location = new System.Drawing.Point(0, 0);
        dgvPatient.Name = "dgvPatient";
        dgvPatient.RowHeadersWidth = 51;
        dgvPatient.Size = new System.Drawing.Size(996, 173);
        dgvPatient.TabIndex = 9;
        dgvPatient.CellClick += dgvPatient_CellClick;
        dgvPatient.CellContentClick += dgvPatient_CellContentClick_1;
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new System.Drawing.Point(310, 194);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new System.Drawing.Size(212, 27);
        txtFirstName.TabIndex = 2;
        // 
        // txtLastName
        // 
        txtLastName.Location = new System.Drawing.Point(310, 237);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new System.Drawing.Size(212, 27);
        txtLastName.TabIndex = 3;
        // 
        // txtEmail
        // 
        txtEmail.Location = new System.Drawing.Point(310, 324);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new System.Drawing.Size(212, 27);
        txtEmail.TabIndex = 5;
        // 
        // dtpBirthDate
        // 
        dtpBirthDate.Location = new System.Drawing.Point(310, 368);
        dtpBirthDate.Name = "dtpBirthDate";
        dtpBirthDate.Size = new System.Drawing.Size(212, 27);
        dtpBirthDate.TabIndex = 6;
        // 
        // btnAddPatient
        // 
        btnAddPatient.ForeColor = System.Drawing.SystemColors.HotTrack;
        btnAddPatient.Location = new System.Drawing.Point(269, 416);
        btnAddPatient.Name = "btnAddPatient";
        btnAddPatient.Size = new System.Drawing.Size(253, 27);
        btnAddPatient.TabIndex = 7;
        btnAddPatient.Text = "Add New Patient";
        btnAddPatient.UseVisualStyleBackColor = true;
        btnAddPatient.Click += btnAddPatient_Click;
        // 
        // txtPhone
        // 
        txtPhone.Location = new System.Drawing.Point(310, 282);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new System.Drawing.Size(212, 27);
        txtPhone.TabIndex = 8;
        // 
        // btnUpdate
        // 
        btnUpdate.ForeColor = System.Drawing.SystemColors.Highlight;
        btnUpdate.Location = new System.Drawing.Point(465, 462);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(129, 71);
        btnUpdate.TabIndex = 10;
        btnUpdate.Text = "update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
        btnDelete.Location = new System.Drawing.Point(158, 462);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(126, 72);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Delete Patient";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnDoctors
        // 
        btnDoctors.ForeColor = System.Drawing.SystemColors.HotTrack;
        btnDoctors.Location = new System.Drawing.Point(12, 560);
        btnDoctors.Name = "btnDoctors";
        btnDoctors.Size = new System.Drawing.Size(153, 77);
        btnDoctors.TabIndex = 12;
        btnDoctors.Text = "Doctor Screen";
        btnDoctors.UseVisualStyleBackColor = true;
        btnDoctors.Click += btnDoctors_Click_1;
        // 
        // btnAppointment
        // 
        btnAppointment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        btnAppointment.ForeColor = System.Drawing.SystemColors.HotTrack;
        btnAppointment.Location = new System.Drawing.Point(210, 570);
        btnAppointment.Name = "btnAppointment";
        btnAppointment.Size = new System.Drawing.Size(270, 56);
        btnAppointment.TabIndex = 13;
        btnAppointment.Text = "Appointment Screen";
        btnAppointment.UseVisualStyleBackColor = false;
        btnAppointment.Click += btnAppointment_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(158, 198);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 14;
        label1.Text = "Name";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(158, 237);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 15;
        label2.Text = "Surname";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(158, 282);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 16;
        label3.Text = "E-mail";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(158, 328);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 17;
        label4.Text = "Phone";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(158, 373);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 18;
        label5.Text = "Birth Date";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(996, 677);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnAppointment);
        Controls.Add(btnDoctors);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(dgvPatient);
        Controls.Add(txtPhone);
        Controls.Add(btnAddPatient);
        Controls.Add(dtpBirthDate);
        Controls.Add(txtEmail);
        Controls.Add(txtLastName);
        Controls.Add(txtFirstName);
        Controls.Add(TestButton);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dgvPatient).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button btnAppointment;

    private System.Windows.Forms.Button btnDoctors;

    private System.Windows.Forms.Button btnDelete;

    private System.Windows.Forms.Button btnUpdate;
    
    private System.Windows.Forms.TextBox txtPhone;

    private System.Windows.Forms.Button btnAddPatient;

    private System.Windows.Forms.DateTimePicker dtpBirthDate;

    private System.Windows.Forms.TextBox txtLastName;

    private System.Windows.Forms.TextBox txtEmail;

    private System.Windows.Forms.TextBox txtFirstName;

    private System.Windows.Forms.DataGridView dgvPatient;

    private System.Windows.Forms.Button TestButton;

    #endregion
}