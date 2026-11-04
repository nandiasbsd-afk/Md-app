using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Md_app
{
    public partial class Formtext : Form
    {
        public Formtext()
        {
            InitializeComponent();
        }
        public void SetFileName(string sFileName)
        {
            StreamReader reader = File.OpenText(sFileName);
            textBox1.Text = reader.ReadToEnd();
            reader.Close();
            textBox1.SelectionLength = 0;
            this.Text = "ТЕКСТ: " + sFileName;
        }

    }
}
