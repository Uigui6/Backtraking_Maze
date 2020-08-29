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
        int horizontal;
        int vertical;

        private void Btn_OFD_Click(object sender, EventArgs e)
        {
            if(FileDialog.ShowDialog() == DialogResult.OK)
            {
                arquivo = FileDialog.FileName;
            }
        }

        private void Btn_Encontrar_Click(object sender, EventArgs e)
        {
            if (arquivo == "")
                throw new Exception("Arquivo não selecionado");

            StreamReader leitor = new StreamReader(arquivo);

            horizontal = int.Parse(leitor.ReadLine());
            vertical = int.Parse(leitor.ReadLine());

            for (int i = 0; ; i++)
                {

                }
        }
    }
}
