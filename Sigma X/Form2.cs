using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Sigma_X
{
    public partial class Form2 : RoundedForm
    {
        private Timer updateTimer; // Timer for simulating the loading delay
        public Point mouseLocation;

        public Form2()
        {
            InitializeComponent();
            InitializeLoadingComponents();
        }

        // Initialize Timer and Label for Loading
        private void InitializeLoadingComponents()
        {
            updateTimer = new Timer();
            updateTimer.Interval = 3000; // 3 seconds
            updateTimer.Tick += UpdateTimer_Tick;

            loadingLabel = new Label(); // Add a loading label programmatically
            loadingLabel.Text = "Loading...";
            loadingLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            loadingLabel.AutoSize = true;
            loadingLabel.Visible = false;
            loadingLabel.Location = new Point(100, 150); // Position it appropriately on the form
            this.Controls.Add(loadingLabel);
        }

        private Label loadingLabel;

        private void Form2_Load(object sender, EventArgs e) { }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string discordInviteLink = "https://get-key.glitch.me/";

            Process.Start(new ProcessStartInfo
            {
                FileName = discordInviteLink,
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (keytext.Text == "Kazi is the best")
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Key Stupid, Try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                keytext.Clear();
                keytext.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadingLabel.Visible = true;  // Show loading animation
            updateTimer.Start();          // Start the timer
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            updateTimer.Stop();           // Stop the timer after loading
            loadingLabel.Visible = false; // Hide the loading label
            MessageBox.Show("No update found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
