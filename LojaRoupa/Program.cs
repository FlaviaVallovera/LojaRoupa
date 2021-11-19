using LojaRoupa.Classes;
using LojaRoupa.Enum;
using System;
using System.Collections.Generic;

namespace LojaRoupa
{
    class Program
    {
		static List<Roupa> lRoupas = new List<Roupa>();
		static void Main(string[] args)
        {
            
			string opcaoUsuario = ObterOpcao();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						Listar();
						break;
					case "2":
						NovaRoupa();
						break;
					case "3":
						AddEstoque();
						break;
					case "4":
						RmEstoque();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcao();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

		private static string ObterOpcao()
		{
			Console.WriteLine();
			Console.WriteLine("Gerenciado de estoque loja de roupas BelaDona");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar roupas");
			Console.WriteLine("2- Inserir nova roupa");
			Console.WriteLine("3- Adicionar ao estoque");
			Console.WriteLine("4- Remover do estoque");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

		private static void Listar()
		{
			Console.WriteLine("Listar Roupas");

			if (lRoupas.Count == 0)
			{
				Console.WriteLine("Nenhuma roupa cadastrada.");
				return;
			}

			for (int i = 0; i < lRoupas.Count; i++)
			{
				Roupa roupa = lRoupas[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(roupa);
			}
		}

		private static void NovaRoupa()
		{
			Console.WriteLine("Inserir nova roupa");

			Console.Write("Digite o Nome da roupa: ");
			string nome = Console.ReadLine();


			Console.Write("Digite numeração da cor da roupa 0-Branco, 1-Azul e 2-Amarelo");
			int cor = int.Parse(Console.ReadLine());

			Console.Write("Qual numeração da roupa?");
			int numeracao = int.Parse(Console.ReadLine());

			Console.Write("Digite 1 para P e 2 para M");
			int tamanho = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor: ");
			double valor = double.Parse(Console.ReadLine());

			Console.Write("quantidade em estoque: ");
			int estoqu = int.Parse(Console.ReadLine());

			Roupa lroupa = new Roupa(nome, (Cor)cor,numeracao,(Tamanho)tamanho, valor, estoqu);
			lRoupas.Add(lroupa);
		}

		private static void AddEstoque()
        {
			Console.WriteLine("Adicionar ao estoque");

			Console.Write("Digite o Nome da roupa: ");
			string nome = Console.ReadLine();

			Console.Write("Quantidade para adicionar ao estoque");
			int qtde = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < lRoupas.Count; i++)
			{
				Roupa lroupa = lRoupas[i];
				if (lroupa.nome == nome)
				{
					lroupa.AdicionarEstoque(qtde);
				}
			}

			Listar();
		}

		private static void RmEstoque()
		{
			Console.WriteLine("Remover do estoque");

			Console.Write("Digite o Nome da roupa: ");
			string nome = Console.ReadLine();

			Console.Write("Quantidade para remover do estoque");
			int qtde = int.Parse(Console.ReadLine());

			for (int i = 0; i < lRoupas.Count; i++)
			{
				Roupa lroupa = lRoupas[i];
				if (lroupa.nome == nome)
				{
					lroupa.RemoverEstoque(qtde);
				}
			}

			Listar();
		}
	}
}
