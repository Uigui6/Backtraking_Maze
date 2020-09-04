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

namespace Labirinto
{
    public partial class FrmCaminhos : Form
    {
        public FrmCaminhos()
        {
            InitializeComponent();
        }

        string arquivo = "";

        private void Btn_OFD_Click(object sender, EventArgs e)
        {
            if(FileDialog.ShowDialog() == DialogResult.OK)
            {
                arquivo = FileDialog.FileName;
            }
        }

        private void Btn_Encontrar_Click(object sender, EventArgs e)
        {
            Labirinto labirinto = new Labirinto(arquivo);
            labirinto.MostrarLabirinto(dgvLabirinto);
            labirinto.BuscarCaminho(dgvLabirinto);
            labirinto.Exibir(dgvCaminhos);
        }
    }
}
