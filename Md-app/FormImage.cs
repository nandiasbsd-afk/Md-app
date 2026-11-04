
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Md_app
{
    public partial class FormImage : Form
    {
        private Bitmap m_bmp = null!;

        public FormImage()
        {
            InitializeComponent();
        }

        public void SetFileName(string sImageName)
        {
            try
            {
                m_bmp = new Bitmap(sImageName);
                this.pictureBox1.Image = (Image)m_bmp;
                this.Text = "Зураг " + sImageName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа: " + ex.ToString());
            }
        }

        private void FormImage_Load(object sender, EventArgs e)
        {

        }
    }
}
