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
using System.Net.NetworkInformation;

namespace Labirinto
{
    public partial class FrmCaminhos : Form
    {
        List<PilhaLista<Caminho>> osCaminhos;
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
            labirinto.ExibirLabirinto(dgvLabirinto);
            osCaminhos = labirinto.BuscarCaminho(dgvLabirinto);
            if (osCaminhos.Count != 0)
            {

                if (osCaminhos.Count == 1)
                    MessageBox.Show($"Foi encontrado apenas um caminho");
                else
                    MessageBox.Show($"Foram encontrados {osCaminhos.Count} caminhos");

                labirinto.ExibirCaminhos(dgvCaminhos);
            }
            else
                MessageBox.Show("O labirinto não tem saída");
        }

        private void dgvCaminhos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int linha = 0; linha < dgvLabirinto.RowCount; linha++)
            {
                for (int coluna = 0; coluna < dgvLabirinto.ColumnCount; coluna++)
                {
                    dgvLabirinto.Rows[linha].Cells[coluna].Style.BackColor = Color.White;
                }
            }

            PilhaLista<Caminho> pilhaOriginal = osCaminhos[dgvCaminhos.CurrentCell.RowIndex];
            PilhaLista<Caminho> pilhaCaminhosClone = pilhaOriginal.Clone();
            while(!pilhaCaminhosClone.EstaVazia)
            {
                Caminho caminhoSelecionado = pilhaCaminhosClone.Desempilhar();

                dgvLabirinto.Rows[caminhoSelecionado.Linha].Cells[caminhoSelecionado.Coluna].Style.BackColor = Color.LightBlue;
            }
        }
    }
}
