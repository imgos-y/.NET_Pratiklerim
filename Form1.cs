using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthcareScheduler;

public partial class Form1 : Form
{
    int selectedPatientId = 0;
    private readonly string _connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";

    public Form1()
    {
        
        InitializeComponent();
        ViewPatient();
    }

    private void button1_Click_2(object sender, EventArgs e)
    {
        string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";

        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            MessageBox.Show("DB bağlantısı BAŞARILI");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message);
        }
    }
    

    private void ViewPatient()
    {
        string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlDataAdapter da = new SqlDataAdapter(
            "SELECT PatientID, FirstName, LastName, DateOfBirth, Phone, Email FROM Patients",
            con
        );
        DataTable dt = new DataTable();
        da.Fill(dt);
        dgvPatient.DataSource = dt;

    }

    private void btnAddPatient_Click(object sender, EventArgs e)
    {
        string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";
        
        if (txtFirstName.Text == "" || txtLastName.Text == "")
        {
            MessageBox.Show(" Name and  Last Name are required");
            return;
            
        }
        if (string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            MessageBox.Show("Email is required");
            return;
        }

        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            @"INSERT INTO Patients 
          (FirstName, LastName, DateOfBirth, Phone, Email)
          VALUES 
          (@FirstName, @LastName, @DateOfBirth, @Phone, @Email)", con);
        
        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = txtFirstName.Text;
        cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = txtLastName.Text;
        cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = dtpBirthDate.Value;
        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text;
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;

        
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        MessageBox.Show(" Added Successfully");
        ViewPatient();
        
        txtFirstName.Clear();
        txtLastName.Clear();
        txtPhone.Clear();
        txtEmail.Clear();

        
    }


    private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        DataGridViewRow row = dgvPatient.Rows[e.RowIndex];

        txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
        txtLastName.Text  = row.Cells["LastName"].Value?.ToString();
        txtPhone.Text     = row.Cells["Phone"].Value?.ToString();
        txtEmail.Text     = row.Cells["Email"].Value?.ToString();

        if (row.Cells["DateOfBirth"].Value != null && row.Cells["DateOfBirth"].Value != DBNull.Value)
            dtpBirthDate.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);

        selectedPatientId = Convert.ToInt32(row.Cells["PatientID"].Value);
    }


    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (selectedPatientId == 0)
        {
            MessageBox.Show("Please select Patient ");
            return;
        }
        string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=HealthcareSchedulerDB;Trusted_Connection=True;";

        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            @"UPDATE Patients SET
            FirstName = @FirstName,
            LastName = @LastName,
            DateOfBirth = @DateOfBirth,
            Phone = @Phone,
            Email = @Email
          WHERE PatientID = @PatientID", con);

        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
        cmd.Parameters.AddWithValue("@DateOfBirth", dtpBirthDate.Value);
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
        cmd.Parameters.AddWithValue("@PatientID", selectedPatientId);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        MessageBox.Show(" Updated Successfully");
        ViewPatient();
        selectedPatientId = 0;
        
        
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (selectedPatientId == 0)
        {
            MessageBox.Show("Please select a patient");
            return;
        }

        var confirm = MessageBox.Show(
            "Are you sure you want to delete this patient?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (confirm != DialogResult.Yes)
            return;

        using SqlConnection con = new SqlConnection(_connectionString);
        using SqlCommand cmd = new SqlCommand(
            "DELETE FROM Patients WHERE PatientID = @PatientID", con);

        cmd.Parameters.AddWithValue("@PatientID", selectedPatientId);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        MessageBox.Show("Patient deleted");

        ViewPatient();
        selectedPatientId = 0;

        txtFirstName.Clear();
        txtLastName.Clear();
        txtPhone.Clear();
        txtEmail.Clear();
    }
    

    private void btnDoctors_Click_1(object sender, EventArgs e)
    {
        Doctor doctorForm = new Doctor();
        doctorForm.ShowDialog();
    }

    private void btnAppointment_Click(object sender, EventArgs e)
    {
        Appointment f = new Appointment();
        f.ShowDialog();
    }

    private void label2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    

    private void dgvPatient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {
        throw new System.NotImplementedException();
    }
    
    
}

