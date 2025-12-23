using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthcareScheduler;

public partial class Appointment : Form
{
    private readonly string _connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";

    public Appointment()
    {
        InitializeComponent();
        LoadDoctors();
        LoadPatients();
        LoadStatus();
        LoadAppointmentsByDate(monthCalendar1.SelectionStart);
        LoadUpcomingReminders(); 
        LoadFilterDoctors();
        LoadFilterPatients();
        LoadFilterStatus();

    }

   
    private void LoadDoctors()
    {
        using SqlConnection con = new SqlConnection(_connectionString);
        using SqlDataAdapter da =
            new SqlDataAdapter("SELECT DoctorID, FullName FROM Doctors", con);

        DataTable dt = new();
        da.Fill(dt);

        cmbDoctors.DisplayMember = "FullName";
        cmbDoctors.ValueMember = "DoctorID";
        cmbDoctors.DataSource = dt;
    }

   
    private void LoadPatients()
    {
        using SqlConnection con = new SqlConnection(_connectionString);
        using SqlDataAdapter da =
            new SqlDataAdapter(
                "SELECT PatientID, FirstName + ' ' + LastName AS FullName FROM Patients",
                con);

        DataTable dt = new();
        da.Fill(dt);

        cmbPatients.DisplayMember = "FullName";
        cmbPatients.ValueMember = "PatientID";
        cmbPatients.DataSource = dt;
    }

    
    private void LoadStatus()
    {
        cmbStatus.Items.Clear();
        cmbStatus.Items.AddRange(new[]
        {
            "Pending",
            "Confirmed",
            "Completed",
            "Cancelled"
        });
        cmbStatus.SelectedIndex = 0;
    }
    

    
    private void LoadAppointmentsByDate(DateTime date)
    {
        using SqlConnection con = new SqlConnection(_connectionString);
        using SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT 
                A.AppointmentID,
                D.FullName AS Doctor,
                P.FirstName + ' ' + P.LastName AS Patient,
                A.AppointmentDate,
                A.Reason,
                A.Status
              FROM Appointments A
              JOIN Doctors D ON A.DoctorID = D.DoctorID
              JOIN Patients P ON A.PatientID = P.PatientID
              WHERE CAST(A.AppointmentDate AS DATE) = @Date",
            con);

        da.SelectCommand.Parameters.AddWithValue("@Date", date.Date);

        DataTable dt = new();
        da.Fill(dt);
        dgvAppointments.DataSource = dt;
    }

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {
        LoadAppointmentsByDate(e.Start);
    }

    
    private void btnAddAppointment_Click(object sender, EventArgs e)
    {
        
        
        
        if (cmbDoctors.SelectedValue == null)
        {
            MessageBox.Show("Doctor must be selected");
            return;
        }

        if (cmbPatients.SelectedValue == null)
        {
            MessageBox.Show("Patient must be selected");
            return;
        }

        if (string.IsNullOrWhiteSpace(txtReason.Text))
        {
            MessageBox.Show("Reason is required");
            return;
        }

        DateTime selectedDate = monthCalendar1.SelectionStart.Date;
        DateTime selectedTime = dtpTime.Value;

        DateTime appointmentDateTime =
            selectedDate.AddHours(selectedTime.Hour)
                .AddMinutes(selectedTime.Minute);



        if (appointmentDateTime < DateTime.Now)
        {
            MessageBox.Show("You cannot select a past date/time");
            return;
        }
        

        using SqlConnection con = new SqlConnection(_connectionString);

        
        using SqlCommand checkCmd = new SqlCommand(
            @"SELECT COUNT(*) FROM Appointments
          WHERE DoctorID = @DoctorID
            AND AppointmentDate = @Date", con);

        checkCmd.Parameters.AddWithValue("@DoctorID", cmbDoctors.SelectedValue);
        checkCmd.Parameters.AddWithValue("@Date", monthCalendar1.SelectionStart);

        con.Open();

        int exists = (int)checkCmd.ExecuteScalar();

        if (exists > 0)
        {
            MessageBox.Show("Doctor has already appointment !");
            con.Close();
            return;
        }
        
        
        using (SqlCommand availabilityCmd = new SqlCommand(
                   @"SELECT COUNT(*) FROM DoctorAvailability
          WHERE DoctorID = @DoctorID
            AND AvailableDate = @Date
            AND @Time BETWEEN StartTime AND EndTime", con))
        {
            availabilityCmd.Parameters.AddWithValue("@DoctorID", cmbDoctors.SelectedValue);
            availabilityCmd.Parameters.AddWithValue("@Date", selectedDate);
            availabilityCmd.Parameters.AddWithValue("@Time", appointmentDateTime.TimeOfDay);

            int available = (int)availabilityCmd.ExecuteScalar();

            if (available == 0)
            {
                MessageBox.Show("Doktor bu tarih ve saatte uygun değil!");
                return;
            }
        }

        
        using SqlCommand cmd = new SqlCommand(
            @"INSERT INTO Appointments
          (DoctorID, PatientID, AppointmentDate, Reason, Status)
          VALUES
          (@DoctorID, @PatientID, @Date, @Reason, @Status)", con);

        cmd.Parameters.AddWithValue("@DoctorID", cmbDoctors.SelectedValue);
        cmd.Parameters.AddWithValue("@PatientID", cmbPatients.SelectedValue);
        cmd.Parameters.AddWithValue("@Date", appointmentDateTime);

        cmd.Parameters.AddWithValue("@Reason", txtReason.Text);
        cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

        cmd.ExecuteNonQuery();
        con.Close();

        MessageBox.Show("Appointment added");
        LoadAppointmentsByDate(monthCalendar1.SelectionStart);
        LoadUpcomingReminders();
        txtReason.Clear();
    }
    private void LoadUpcomingReminders()
    {
        using SqlConnection con = new SqlConnection(_connectionString);
        using SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT 
            COUNT(*) 
          FROM Appointments
          WHERE AppointmentDate >= GETDATE()
            AND AppointmentDate < DATEADD(HOUR, 24, GETDATE())
            AND Status IN ('Pending', 'Confirmed')",
            con);

        DataTable dt = new DataTable();
        da.Fill(dt);

        int count = Convert.ToInt32(dt.Rows[0][0]);

        if (count > 0)
        {
            lblReminder.Text = $"⚠ {count} appointment(s) in next 24 hours!";
        }
        else
        {
            lblReminder.Text = "";
        }
    }


    private void dtpTime_ValueChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
    private void LoadFilterDoctors()
    {
        using SqlConnection con = new SqlConnection(_connectionString);
        using SqlDataAdapter da = new SqlDataAdapter(
            "SELECT DoctorID, FullName FROM Doctors", con);

        DataTable dt = new DataTable();
        da.Fill(dt);

        DataRow row = dt.NewRow();
        row["DoctorID"] = 0;
        row["FullName"] = "All Doctors";
        dt.Rows.InsertAt(row, 0);

        cmbFilterDoctor.DisplayMember = "FullName";
        cmbFilterDoctor.ValueMember = "DoctorID";
        cmbFilterDoctor.DataSource = dt;
    }
    private void LoadFilterPatients()
    {
        using SqlConnection con = new SqlConnection(_connectionString);
        using SqlDataAdapter da = new SqlDataAdapter(
            "SELECT PatientID, FirstName + ' ' + LastName AS FullName FROM Patients", con);

        DataTable dt = new DataTable();
        da.Fill(dt);

        DataRow row = dt.NewRow();
        row["PatientID"] = 0;
        row["FullName"] = "All Patients";
        dt.Rows.InsertAt(row, 0);

        cmbFilterPatients.DisplayMember = "FullName";
        cmbFilterPatients.ValueMember = "PatientID";
        cmbFilterPatients.DataSource = dt;
    }
    private void LoadFilterStatus()
    {
        cmbFilterStatus.Items.Clear();
        cmbFilterStatus.Items.AddRange(new string[]
        {
            "All Status",
            "Pending",
            "Confirmed",
            "Completed",
            "Cancelled"
        });
        cmbFilterStatus.SelectedIndex = 0;
    }
    
    private void LoadFilteredAppointments()
    {
        using SqlConnection con = new SqlConnection(_connectionString);

        string query = @"
        SELECT 
            A.AppointmentID,
            D.FullName AS Doctor,
            P.FirstName + ' ' + P.LastName AS Patient,
            A.AppointmentDate,
            A.Reason,
            A.Status
        FROM Appointments A
        JOIN Doctors D ON A.DoctorID = D.DoctorID
        JOIN Patients P ON A.PatientID = P.PatientID
        WHERE CAST(A.AppointmentDate AS DATE) = @Date
    ";

        if ((int)cmbFilterDoctor.SelectedValue != 0)
            query += " AND A.DoctorID = @DoctorID";

        if ((int)cmbFilterPatients.SelectedValue != 0)
            query += " AND A.PatientID = @PatientID";

        if (cmbFilterStatus.Text != "All Status")
            query += " AND A.Status = @Status";

        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Date", monthCalendar1.SelectionStart.Date);

        if ((int)cmbFilterDoctor.SelectedValue != 0)
            cmd.Parameters.AddWithValue("@DoctorID", cmbFilterDoctor.SelectedValue);

        if ((int)cmbFilterPatients.SelectedValue != 0)
            cmd.Parameters.AddWithValue("@PatientID", cmbFilterPatients.SelectedValue);

        if (cmbFilterStatus.Text != "All Status")
            cmd.Parameters.AddWithValue("@Status", cmbFilterStatus.Text);

        DataTable dt = new DataTable();
        using SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        dgvAppointments.DataSource = dt;
    }



    private void btnFilter_Click(object sender, EventArgs e)
    {
        LoadFilteredAppointments();
    }
}
