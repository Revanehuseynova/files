namespace files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelHeader = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            btnRead = new Button();
            btnDelete = new Button();
            btnWrite = new Button();
            btnSave = new Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SkyBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.RightToLeft = RightToLeft.No;
            panelHeader.Size = new Size(715, 145);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(281, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PAPERMAN";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.LightSteelBlue;
            panelMain.Controls.Add(pictureBox4);
            panelMain.Controls.Add(pictureBox3);
            panelMain.Controls.Add(pictureBox2);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(richTextBox1);
            panelMain.Controls.Add(btnRead);
            panelMain.Controls.Add(btnDelete);
            panelMain.Controls.Add(btnWrite);
            panelMain.Controls.Add(btnSave);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 145);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(715, 367);
            panelMain.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(167, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(167, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(167, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.add_file1;
            pictureBox1.Location = new Point(167, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(324, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(383, 361);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(23, 267);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(235, 67);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read file";
            btnRead.TextAlign = ContentAlignment.MiddleLeft;
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(23, 179);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(235, 67);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete file";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(23, 92);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(235, 67);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write file";
            btnWrite.TextAlign = ContentAlignment.MiddleLeft;
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnSave
            // 
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(23, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(235, 67);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save file";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 512);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Files";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelMain;
        private Label lblTitle;
        private Button btnRead;
        private Button btnDelete;
        private Button btnWrite;
        private Button btnSave;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}