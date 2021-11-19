using LojaRoupa.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaRoupa.Classes
{
    public class Roupa
    {
        private Cor cor { get; set; }
        private int numeracao { get; set; }
        private Tamanho tamanho { get; set; }
        private double valor { get; set; }
        private int estoque { get; set; }
        public string nome { get; set; }
        public Roupa(string lnome, Cor lcor, int lnumeracao, Tamanho ltamanho, double lvalor, int lestoque)
        {
            cor = lcor;
            numeracao= lnumeracao;
            tamanho = ltamanho;
            valor = lvalor;
            estoque = lestoque;
            nome = lnome;
        }

        public int AdicionarEstoque(int valor)
        {
            Console.WriteLine("Adicionado "+ valor + "itens ao estoque");
            estoque += valor;

            return estoque;
        }

        public int RemoverEstoque(int valor)
        {
            Console.WriteLine("Retirado " + valor + "itens do estoque");
            estoque -= valor;

            return estoque;
        }


        public override string ToString()
        {
            string retorno = "";
            retorno += "Roupa " + this.nome + " | ";
            retorno += "Cor " + this.cor + " | ";
            retorno += "Num " + this.numeracao + " | ";
            retorno += "Tam " + this.tamanho + " | ";
            retorno += "Valor R$" + this.valor + " | ";
            retorno += "Estoque " + this.estoque;
            return retorno;
        }
    }
}
