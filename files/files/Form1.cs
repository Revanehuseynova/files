using System;
using System.IO;
using System.Windows.Forms;

namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save file";
            save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            save.DefaultExt = "txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
                File.WriteAllText(filePath, richTextBox1.Text);

                MessageBox.Show("Fayl uğurla saxlanıldı",
                    "Məlumat", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                File.WriteAllText(filePath, richTextBox1.Text);

                MessageBox.Show("Fayla məlumat yazıldı",
                    "Məlumat", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save file";
                save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                save.DefaultExt = "txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    filePath = save.FileName;
                    File.WriteAllText(filePath, richTextBox1.Text);

                    MessageBox.Show("Fayl uğurla saxlanıldı",
                        "Məlumat", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Silinəcək faylı seçin";
            open.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                DialogResult d = MessageBox.Show(
                    "Fayl silinsinmi?",
                    "Sual",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    File.Delete(open.FileName);

                    if (filePath == open.FileName)
                    {
                        filePath = "";
                        richTextBox1.Clear();
                    }

                    MessageBox.Show("Fayl silindi",
                        "Məlumat", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Oxunacaq faylı seçin";
            open.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
                richTextBox1.Text = File.ReadAllText(filePath);
            }
        }
    }
}