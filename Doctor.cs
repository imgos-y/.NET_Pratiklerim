using Microsoft.Data.SqlClient;
using System.Data;
namespace HealthcareScheduler;

public partial class Doctor : Form
{
    int selectedDoctorId = 0;
    string connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";
    
    public Doctor()
    {
        InitializeComponent();
        LoadDoctors();
        
    }
    private void LoadDoctors()
    {
        string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";

        using SqlConnection con = new SqlConnection(connectionString);
        using SqlDataAdapter da = new SqlDataAdapter(
            "SELECT DoctorID, FullName, Specialization FROM Doctors",
            con
        );

        DataTable dt = new DataTable();
        da.Fill(dt);
        dgvDoctors.DataSource = dt;
        
        cmbDoctors.DisplayMember = "FullName";
        cmbDoctors.ValueMember = "DoctorID";
        cmbDoctors.DataSource = dt;
    }


    private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }

    private void btnAddDoctor_Click(object sender, EventArgs e)
    {
        if (txtDoctorName.Text == "" || txtSpecialization.Text == "")
        {
            MessageBox.Show(" name and specialization can't be empty");
            return;
        }

        using SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(
            "INSERT INTO Doctors (FullName, Specialization) VALUES (@n,@s)", con);

        cmd.Parameters.AddWithValue("@n", txtDoctorName.Text);
        cmd.Parameters.AddWithValue("@s", txtSpecialization.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        LoadDoctors();
        txtDoctorName.Clear();
        txtSpecialization.Clear();
    }

    private void btnAddAvailability_Click(object sender, EventArgs e)
    {
        if (cmbDoctors.SelectedValue == null)
        {
            MessageBox.Show("Doctor required");
            return;
        }

        if (dtpEndTime.Value <= dtpStartTime.Value)
        {
            MessageBox.Show("End time must be after start time");
            return;
        }

        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            @"INSERT INTO DoctorAvailability
          (DoctorID, AvailableDate, StartTime, EndTime)
          VALUES
          (@DoctorID, @Date, @StartTime, @EndTime)", con);

        cmd.Parameters.AddWithValue("@DoctorID", cmbDoctors.SelectedValue);
        cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
        cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.TimeOfDay);
        cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.TimeOfDay);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        MessageBox.Show("Availability added");
    }
}