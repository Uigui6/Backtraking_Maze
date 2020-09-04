using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Labirinto
{
    class Labirinto
    {
        int horizontal = 0;
        int vertical = 0;
        char[,] matriz;
        List<PilhaLista<Caminho>> listaCaminho = new List<PilhaLista<Caminho>>();
        PilhaLista<Caminho> pilhaCaminhos = new PilhaLista<Caminho>();

        internal List<PilhaLista<Caminho>> ListaCaminho { get => listaCaminho; set => listaCaminho = value; }

        public Labirinto(String arquivo)
        {
            if (arquivo == "")
                throw new Exception("Arquivo não selecionado");

            StreamReader leitor = new StreamReader(arquivo);

            horizontal = int.Parse(leitor.ReadLine());
            vertical = int.Parse(leitor.ReadLine());
            matriz = new char[vertical, horizontal];


            for (int linha = 0; linha < vertical; linha++)
            {
                string lab = leitor.ReadLine();
                for (int coluna = 0; coluna < horizontal; coluna++)
                {
                    matriz[linha, coluna] = lab[coluna];
                }
            }
        }

        public void ExibirLabirinto(DataGridView dgv)
        {
            dgv.RowCount = vertical;
            dgv.ColumnCount = horizontal;
            for (int linha = 0; linha < vertical; linha++)
            {
                for (int coluna = 0; coluna < horizontal; coluna++)
                {
                    dgv.Columns[coluna].Width = 20;
                    dgv.Rows[linha].Cells[coluna].Value = matriz[linha, coluna];
                }
            }
            Application.DoEvents();
        }

        public List<PilhaLista<Caminho>> BuscarCaminho(DataGridView dgvLabirinto)
        {
            int linhaAtual = 1;
            int colunaAtual = 1;
            int proximaLinha, proximaColuna;
            int naoAchouCaminho = 0;
            
            pilhaCaminhos.Empilhar(new Caminho(1, 1));
            Mover(1, 1, true, dgvLabirinto);

            int[] movimentoLinha = {-1, -1, 0, 1, 1, 1, 0, -1};
            int[] movimentoColuna = {0, 1, 1, 1, 0, -1, -1, -1};
            bool temCaminho = true;
            bool seMoveu = false;

            while (temCaminho)
            {
                int direcao;
                try
                {
                    direcao = int.Parse(matriz[linhaAtual, colunaAtual] + "");
                }
                catch (Exception e)
                {
                    direcao = -1;
                }

                seMoveu = false;

                for (int i = direcao + 1; i < movimentoLinha.Length && !seMoveu; i++)
                {
                    proximaLinha = linhaAtual + movimentoLinha[i];
                    proximaColuna = colunaAtual + movimentoColuna[i];

                    if (matriz[proximaLinha, proximaColuna] == 'S')
                    {
                        pilhaCaminhos.Empilhar(new Caminho(proximaLinha, proximaColuna));
                        listaCaminho.Add(pilhaCaminhos.Clone());
                        pilhaCaminhos.Desempilhar();
                        Mover(proximaLinha, proximaColuna, true, dgvLabirinto);
                        Mover(proximaLinha, proximaColuna, false, dgvLabirinto);
                        naoAchouCaminho++;
                    }
                    else if (matriz[proximaLinha, proximaColuna] == ' ')
                    {
                        pilhaCaminhos.Empilhar(new Caminho(proximaLinha, proximaColuna));
                        matriz[linhaAtual, colunaAtual] = char.Parse(i + "");
                        linhaAtual = proximaLinha;
                        colunaAtual = proximaColuna;
                        seMoveu = true;
                        naoAchouCaminho = 0;
                        Mover(proximaLinha, proximaColuna, true, dgvLabirinto);
                    }
                }
                if (!seMoveu)
                {
                    Caminho caminhoAntigo = pilhaCaminhos.Desempilhar();
                    matriz[caminhoAntigo.Linha, caminhoAntigo.Coluna] = ' ';
                    Mover(caminhoAntigo.Linha, caminhoAntigo.Coluna, false, dgvLabirinto);

                    if (pilhaCaminhos.EstaVazia)
                        temCaminho = false;
                    else
                    {
                        Caminho caminho = pilhaCaminhos.OTopo();
                        linhaAtual = caminho.Linha;
                        colunaAtual = caminho.Coluna;
                        naoAchouCaminho = 0;
                    }
                }
            }

            return listaCaminho;
        }

        public void ExibirCaminhos(DataGridView dgv)
        {
            int i = 0;
            dgv.ColumnCount = 100;
            dgv.RowCount = listaCaminho.Count;
            foreach (PilhaLista<Caminho> caminho in listaCaminho)
            {
                PilhaLista<Caminho> caminhoClone = caminho.Clone();
                for (int j = caminho.Tamanho - 1; j >= 0; j--)
                {
                    dgv.Columns[j].Width = 50;
                    Caminho umCaminho = caminhoClone.Desempilhar();
                    dgv.Rows[i].Cells[j].Value = umCaminho;
                }
                i++;
            }
            Application.DoEvents();
        }

        public void Mover(int linha, int coluna, bool avanco, DataGridView dgvLabirinto)
        {
            if (avanco)
            {
                dgvLabirinto.Rows[linha].Cells[coluna].Style.BackColor = Color.Green;
            }
            else
                dgvLabirinto.Rows[linha].Cells[coluna].Style.BackColor = Color.White;

            Application.DoEvents();
        }

    }
}
