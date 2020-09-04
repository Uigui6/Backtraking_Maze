using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    class Caminho : IComparable<Caminho>
    {
        int linha, coluna;

        public Caminho(int l, int c)
        {
            linha = l;
            coluna = c;
        }

        public int Linha { get => linha; set => linha = value; }
        public int Coluna { get => coluna; set => coluna = value; }

        public int CompareTo(Caminho other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "" + linha + ", " + coluna;
        }
    }
}
