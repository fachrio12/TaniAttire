using System;
using System.Windows.Forms;
using Npgsql;
using TaniAttire;

namespace TaniAttire
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=NabilBaihaqi04;Database=TaniAttire";
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT role FROM users WHERE username = @username AND password = @password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Menggunakan parameter untuk mencegah SQL Injection
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text); // Pastikan password dienkripsi atau di-hash di basis data.

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Ambil role dari hasil query
                                string role = reader["role"].ToString();

                                // Periksa role dan buka form yang sesuai
                                if (role == "1")
                                {
                                    MessageBox.Show("Login berhasil sebagai Auditor!");
                                    AuditorDashboard auditorForm = new AuditorDashboard();
                                    auditorForm.Show();
                                    this.Hide();
                                }
                                else if (role == "2")
                                {
                                    MessageBox.Show("Login berhasil sebagai Kasir!");
                                    KasirDashboard kasirForm = new KasirDashboard();
                                    kasirForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Role tidak dikenali.");
                                }
                            }
                            else
                            {
                                // Login gagal
                                MessageBox.Show("Username atau password salah.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
