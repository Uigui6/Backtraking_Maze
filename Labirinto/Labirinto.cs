using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Labirinto
{
    class Labirinto
    {
        int horizontal = 0;
        int vertical = 0;
        char[,] matriz;

        public Labirinto(String arquivo)
        {
            if (arquivo == "")
                throw new Exception("Arquivo não selecionado");

            StreamReader leitor = new StreamReader(arquivo);

            horizontal = int.Parse(leitor.ReadLine());
            vertical = int.Parse(leitor.ReadLine());
            matriz = new char[vertical, horizontal];
 

            for(int linha = 0; linha < vertical; linha++)
            {
                string lab = leitor.ReadLine();
                for(int coluna = 0; coluna < horizontal; coluna++)
                {
                    matriz[linha, coluna] = char.Parse(lab.Substring(coluna, 1));
                }
            }
        }

        public void MostrarLabirinto(DataGridView dgv)
        {
            for(int linha = 0; linha < vertical; linha++)
            {
                for(int coluna = 0; coluna < horizontal; coluna++)
                {
                    dgv.RowCount = vertical;
                    dgv.ColumnCount = horizontal;

                    dgv[coluna, linha].Value = matriz[linha, coluna];
                    dgv.Columns[coluna].Width = 20;
                }
            }
        }

        public PilhaLista<Caminho> BuscarCaminho(DataGridView dgv)
        {
            int linhaAtual = 1;
            int colunaAtual = 1;
            int naoAchouCaminho = 0;
            PilhaLista<Caminho> pilhaCaminhos = new PilhaLista<Caminho>();
            String[] caminhosPossiveis = new String[100];
            string caminhoAtual; 
            //pilhaCaminhos.Empilhar(new Caminho(1, 1));

            int[] movimentoLinha = {-1, -1, 0, 1, 1, 1, 0, -1};
            int[] movimentoColuna = {0, 1, 1, 1, 0, -1, -1, -1};
            bool temCaminho = true;
            bool seMoveu = false;

            dgv.RowCount = vertical;
            dgv.ColumnCount = horizontal;

            while (temCaminho)
            {
                for(int i = 0; i < movimentoLinha.Length && !seMoveu; i++)
                {
                    int proximaLinha = linhaAtual + movimentoLinha[i];
                    int proximaColuna = colunaAtual + movimentoColuna[i];

                    if (matriz[proximaLinha, proximaColuna] == 'S')
                    {
                        pilhaCaminhos.Empilhar(new Caminho(linhaAtual, colunaAtual));
                        pilhaCaminhos.Empilhar(new Caminho(proximaLinha, proximaColuna));
                        naoAchouCaminho = 0;
                    }
                    else if (matriz[proximaLinha, proximaColuna] == ' ')
                    {
                        pilhaCaminhos.Empilhar(new Caminho(linhaAtual, colunaAtual));
                        linhaAtual = proximaLinha;
                        colunaAtual = proximaColuna;
                        seMoveu = true;
                        naoAchouCaminho = 0;
                    }
                    else
                    {
                        naoAchouCaminho++;
                        if(naoAchouCaminho == 8)
                        {
                            if(pilhaCaminhos.EstaVazia)
                            {
                                dgv[0, 0].Value = "O labirinto é infazível";
                                temCaminho = false;
                            }
                            pilhaCaminhos.Desempilhar();
                        }
                    }
                }
            }

            return pilhaCaminhos;
        }
    }
}
