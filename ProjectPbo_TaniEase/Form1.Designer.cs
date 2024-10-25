namespace ProjectPbo_TaniEase
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Hv BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(192, 46);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(192, 218);
            button2.Name = "button2";
            button2.Size = new Size(92, 37);
            button2.TabIndex = 2;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonLogin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(134, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 330);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 141);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 97);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label3;
        private Label label2;
    }
}
