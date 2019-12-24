using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class mainChar : UserControl
    {
        public mainChar ()
        {
            InitializeComponent();
            // label_name.Text = "克西和夫";
        }

        private void mainChar_Load (object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick (object sender, EventArgs e)
        {
            OpenFileDialog upload_Avatar = new OpenFileDialog();
            upload_Avatar.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (upload_Avatar.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(upload_Avatar.FileName);
            }            
        }

        private void label_name_DoubleClick (object sender, EventArgs e)
        {
            TextBox rename = new TextBox();
            rename.Location = label_name.Location;
            rename.Width = label_name.Width;
            rename.Height = label_name.Height;
            rename.Text = label_name.Text;
            this.Controls.Add(rename);
            rename.BringToFront();
            rename.KeyDown += new KeyEventHandler(this.rename_Enter);
        }

        private void rename_Enter (object sender, KeyEventArgs e)
        {
            TextBox text = sender as TextBox;
            if (e.KeyCode == Keys.Enter && text.Text != "")
            {
                label_name.Text = text.Text;
                text.Dispose();
                label_name.BringToFront();
            }
        }
    }
}
