using System;
using System.Windows.Forms;
using Npgsql;

namespace ProjectPbo_TaniEase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Triplef33;Database=TaniEase";
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Menggunakan parameter untuk mencegah SQL Injection
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text); // Pastikan ini bukan sandi dalam bentuk teks biasa di basis data.

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login berhasil
                                MessageBox.Show("Login berhasil!");

                                // Buka form dashboard setelah login berhasil
                                Dashboard dashboardForm = new Dashboard();
                                dashboardForm.Show();

                                // Sembunyikan form login (Form1)
                                this.Hide();
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
    }
}
