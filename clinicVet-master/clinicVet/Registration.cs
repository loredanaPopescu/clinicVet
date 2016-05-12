using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicVet
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            loadcaptchaimage();
        }

        int number = 0;
        private void loadcaptchaimage() {
            Random r1 = new Random();
            number = r1.Next(100,10000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.ForestGreen, new Point(0, 0));
            pictureBox1.Image = image;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadcaptchaimage();
            captcha.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (captcha.Text == number.ToString())
            {
                MessageBox.Show("Match Text with capcha!");
            }
            else {
                MessageBox.Show("Does not match with capcha!");
                loadcaptchaimage();
                captcha.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBox2.Image = Image.FromFile(OpenFd.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
