namespace ProjectPbo_TaniEase
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelSidebar = new Panel();
            buttonLogOut = new Button();
            buttonLaporan = new Button();
            buttonTransaksi = new Button();
            buttonProduk = new Button();
            buttonBeranda = new Button();
            labelBeranda = new Label();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.LightGreen;
            panelSidebar.Controls.Add(buttonLogOut);
            panelSidebar.Controls.Add(buttonLaporan);
            panelSidebar.Controls.Add(buttonTransaksi);
            panelSidebar.Controls.Add(buttonProduk);
            panelSidebar.Controls.Add(buttonBeranda);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 450);
            panelSidebar.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Red;
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(12, 380);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Padding = new Padding(30, 0, 0, 0);
            buttonLogOut.Size = new Size(176, 40);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "   Log Out";
            buttonLogOut.MouseEnter += button_MouseEnter;
            buttonLogOut.MouseLeave += button_MouseLeave;
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // buttonLaporan
            // 
            buttonLaporan.BackColor = Color.White;
            buttonLaporan.ForeColor = Color.Green;
            buttonLaporan.Image = (Image)resources.GetObject("buttonLaporan.Image");
            buttonLaporan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLaporan.Location = new Point(12, 205);
            buttonLaporan.Name = "buttonLaporan";
            buttonLaporan.Padding = new Padding(30, 0, 0, 0);
            buttonLaporan.Size = new Size(176, 59);
            buttonLaporan.TabIndex = 3;
            buttonLaporan.Text = "    Laporan dan Forecasting";
            buttonLaporan.MouseEnter += button_MouseEnter1;
            buttonLaporan.MouseLeave += button_MouseLeave1;
            buttonLaporan.UseVisualStyleBackColor = false;
            buttonLaporan.Click += buttonLaporan_Click;
            // 
            // buttonTransaksi
            // 
            Image originalImage = (Image)resources.GetObject("buttonTransaksi.Image");
            Image resizedImage = new Bitmap(originalImage, new Size(24, 24));
            buttonTransaksi.BackColor = Color.White;
            buttonTransaksi.ForeColor = Color.Green;
            buttonTransaksi.Image = resizedImage;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(12, 159);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Padding = new Padding(30, 0, 0, 0);
            buttonTransaksi.Size = new Size(176, 40);
            buttonTransaksi.TabIndex = 2;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.MouseEnter += button_MouseEnter1;
            buttonTransaksi.MouseLeave += button_MouseLeave1;
            buttonTransaksi.UseVisualStyleBackColor = false;
            // 
            // buttonProduk
            // 
            buttonProduk.BackColor = Color.White;
            buttonProduk.ForeColor = Color.Green;
            buttonProduk.Image = (Image)resources.GetObject("buttonProduk.Image");
            buttonProduk.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProduk.Location = new Point(12, 113);
            buttonProduk.Name = "buttonProduk";
            buttonProduk.Padding = new Padding(30, 0, 0, 0);
            buttonProduk.Size = new Size(176, 40);
            buttonProduk.TabIndex = 1;
            buttonProduk.Text = "         Pengelolaan Produk";
            buttonProduk.MouseEnter += button_MouseEnter1;
            buttonProduk.MouseLeave += button_MouseLeave1;
            buttonProduk.UseVisualStyleBackColor = false;
            buttonProduk.Click += buttonProduk_Click;
            // 
            // buttonBeranda
            // 
            Image original = (Image)resources.GetObject("buttonBeranda.Image");
            Image resized = new Bitmap(original, new Size(24, 24));
            buttonBeranda.BackColor = Color.ForestGreen;
            buttonBeranda.ForeColor = Color.White;
            buttonBeranda.Image = resized;
            buttonBeranda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBeranda.Location = new Point(12, 67);
            buttonBeranda.Name = "buttonBeranda";
            buttonBeranda.Padding = new Padding(30, 0, 0, 0);
            buttonBeranda.Size = new Size(176, 40);
            buttonBeranda.TabIndex = 0;
            buttonBeranda.Text = "Beranda";
            buttonBeranda.MouseEnter += button_MouseEnter1;
            buttonBeranda.MouseLeave += button_MouseLeave1;
            buttonBeranda.UseVisualStyleBackColor = false;
            // 
            // labelBeranda
            // 
            labelBeranda.AutoSize = true;
            labelBeranda.Font = new Font("Arial", 24F, FontStyle.Bold);
            labelBeranda.ForeColor = Color.Green;
            labelBeranda.Location = new Point(300, 40);
            labelBeranda.Name = "labelBeranda";
            labelBeranda.Size = new Size(144, 37);
            labelBeranda.TabIndex = 1;
            labelBeranda.Text = "Beranda";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBeranda);
            Controls.Add(panelSidebar);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load_1;
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonLaporan;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button buttonProduk;
        private System.Windows.Forms.Button buttonBeranda;
        private System.Windows.Forms.Label labelBeranda;
    }
}
