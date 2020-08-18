using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string arquivo;

        private void Btn_OFD_Click(object sender, EventArgs e)
        {
            if(FileDialog.ShowDialog() == DialogResult.OK);
            {
                arquivo = FileDialog.FileName;
            }
        }

        private void Btn_Encontrar_Click(object sender, EventArgs e)
        {

        }
    }
}
