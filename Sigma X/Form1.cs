using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using cxapi;

namespace Sigma_X
{
    public partial class Form1 : RoundedForm
    {
        private Timer timer;
        public Point mouseLocation;

        public Form1()
        {
            InitializeComponent();
            CoreFunctions.setconfig("Nova X", "V0.69", "Injected");

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timertick;
            timer.Start();
        }

        private void timertick(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsRobloxOpen())
            {
                robloxopen.Text = "Roblox Open: ✅";
                robloxopen.ForeColor = Color.LightGreen;
            }
            else
            {
                robloxopen.Text = "Roblox Open: ❌";
                robloxopen.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoreFunctions.Inject(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(Editor.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoreFunctions.KillRoblox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Editor.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   
        }

        private void robloxopen_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editor.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        class functions
        {
            public static void PopulateListBox(System.Windows.Forms.ListBox lsb, string Folder, string FileType)
            {
                DirectoryInfo dinfo = new DirectoryInfo(Folder);
                    FileInfo[] Files = dinfo.GetFiles(FileType);
                foreach (FileInfo file in Files)
                {
                    lsb.Items.Add(file.Name);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
            functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
        }

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

        private void button10_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt",
                DefaultExt = "lua",
                Title = "Save Lua or Text File"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string textToSave = Editor.Text;
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textToSave);
                }
            }   
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt",
                Title = "Open Lua or Text File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Editor.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
    }
}
