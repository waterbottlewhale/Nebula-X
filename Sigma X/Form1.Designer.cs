namespace Sigma_X
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.robloxopen = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(704, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Inject";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(232, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kill Roblox";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Editor
            // 
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Editor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.Editor.AutoScrollMinSize = new System.Drawing.Size(307, 14);
            this.Editor.BackBrush = null;
            this.Editor.BackColor = System.Drawing.Color.DarkGray;
            this.Editor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.Editor.CharHeight = 14;
            this.Editor.CharWidth = 8;
            this.Editor.CommentPrefix = "--";
            this.Editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Editor.ForeColor = System.Drawing.SystemColors.Control;
            this.Editor.IndentBackColor = System.Drawing.Color.DarkGray;
            this.Editor.IsReplaceMode = false;
            this.Editor.Language = FastColoredTextBoxNS.Language.Lua;
            this.Editor.LeftBracket = '(';
            this.Editor.LeftBracket2 = '{';
            this.Editor.LineNumberColor = System.Drawing.Color.Black;
            this.Editor.Location = new System.Drawing.Point(12, 37);
            this.Editor.Name = "Editor";
            this.Editor.Paddings = new System.Windows.Forms.Padding(0);
            this.Editor.RightBracket = ')';
            this.Editor.RightBracket2 = '}';
            this.Editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Editor.ServiceColors")));
            this.Editor.ServiceLinesColor = System.Drawing.Color.Black;
            this.Editor.Size = new System.Drawing.Size(686, 361);
            this.Editor.TabIndex = 3;
            this.Editor.Text = "print(\"Nova X made by Kazi Hassan\")";
            this.Editor.Zoom = 100;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-4, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nova X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(122, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(772, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 26);
            this.button5.TabIndex = 6;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(718, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 26);
            this.button6.TabIndex = 7;
            this.button6.Text = "–";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Location = new System.Drawing.Point(745, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 26);
            this.button7.TabIndex = 8;
            this.button7.Text = "☐";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // robloxopen
            // 
            this.robloxopen.AutoSize = true;
            this.robloxopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.robloxopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robloxopen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.robloxopen.Location = new System.Drawing.Point(29, 11);
            this.robloxopen.Name = "robloxopen";
            this.robloxopen.Size = new System.Drawing.Size(87, 16);
            this.robloxopen.TabIndex = 9;
            this.robloxopen.Text = "Roblox open:";
            this.robloxopen.Click += new System.EventHandler(this.robloxopen_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(699, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 368);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGray;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(718, 377);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 21);
            this.button8.TabIndex = 11;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // openfile
            // 
            this.openfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openfile.BackColor = System.Drawing.Color.DarkGray;
            this.openfile.ForeColor = System.Drawing.SystemColors.Control;
            this.openfile.Location = new System.Drawing.Point(484, 404);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(104, 42);
            this.openfile.TabIndex = 12;
            this.openfile.Text = "Open";
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button10.BackColor = System.Drawing.Color.DarkGray;
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(594, 404);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(104, 42);
            this.button10.TabIndex = 13;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(810, 458);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.robloxopen);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private FastColoredTextBoxNS.FastColoredTextBox Editor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label robloxopen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button button10;
    }
}

