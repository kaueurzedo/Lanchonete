using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    internal class Lanches
    {
        public string Nome;
        public int Codigo;
        public double Preco;

       
        public Lanches(string nome, int codigo, double preco) 
        {
        Nome= nome;
        Codigo= codigo; 
        Preco= preco;
        
        
        }
    }
namespace Lanchonete
{
    internal class program
    {

        static void Main(string[] args)
        {
            int Codigo1, Quantidade;
            double Total;
            String Sair = "";


            Lanches l1 = new Lanches(" X-BUGUER ", 1, 20.90);
            Lanches l2 = new Lanches(" X-BACON ", 2, 21.90);
            Lanches l3 = new Lanches(" AMERICANO ", 3, 19.90);
            Lanches l4 = new Lanches(" MISTO QUENTE ", 4, 15.90);
            Lanches l5 = new Lanches(" X-SALADA ", 5, 18.90);
            Lanches l6 = new Lanches(" BATATA FRITA ", 6, 9.90);
            Lanches l7 = new Lanches(" COCA COLA ", 7, 5);
            Lanches l8 = new Lanches(" X-PICANHA ", 8, 23.90);
            Lanches l9 = new Lanches(" GUARANA ANTARTCA ", 9, 5);

            Console.WriteLine("-------------------------------------------\nBEM VINDO AO MONSTER BURGUER\n-------------------------------\n");

            do
            {

                Console.WriteLine("----------------------------------------------\nCARDAPIO\n-------------------\n");
            Console.WriteLine("{0}{1}{2}", l1.Codigo, l1.Nome, l1.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l2.Codigo, l2.Nome, l2.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l3.Codigo, l3.Nome, l3.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l4.Codigo, l4.Nome, l4.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l5.Codigo, l5.Nome, l5.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l6.Codigo, l6.Nome, l6.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l7.Codigo, l7.Nome, l7.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l8.Codigo, l8.Nome, l8.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}{1}{2}", l9.Codigo, l9.Nome, l9.Preco.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("----------------------------------------------\nPEDIDO\n-------------------\n");



                Console.Write("FAÇA SEU PEDIDO DIGITANDO O CODIGO DO PRODUTO ");
            Codigo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nQUANTAS UNIDADES ?: ");
            Quantidade = Convert.ToInt32(Console.ReadLine());

          

                if (Codigo1 == 1)
                {
                    Console.Clear();
                    Total = (Quantidade * l1.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l1.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));

                }

                else if (Codigo1 == 2)
                {
                    Console.Clear();
                    Total = (Quantidade * l2.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l2.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));


                }

                else if (Codigo1 == 3)
                {
                    Console.Clear();
                    Total = (Quantidade * l3.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l3.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));


                }

                else if (Codigo1 == 4)
                {
                    Console.Clear();
                    Total = (Quantidade * l4.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l4.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));


                }

                else if (Codigo1 == 5)
                {
                    Console.Clear();
                    Total = (Quantidade * l5.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l5.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));


                }
                else if (Codigo1 == 6)
                {
                    Console.Clear();
                    Total = (Quantidade * l6.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l6.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));


                }
                else if (Codigo1 == 7)
                {
                    Console.Clear();
                    Total = (Quantidade * l7.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l7.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));


                }
                else if (Codigo1 == 8)
                {
                    Console.Clear();
                    Total = (Quantidade * l8.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l8.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));


                }

                else if (Codigo1 == 9)
                {
                    Console.Clear();
                    Total = (Quantidade * l9.Preco);
                    Console.WriteLine("----------------------------------------------\nPEDIDO CONSULTADO\n-------------------\n");
                    Console.WriteLine("VOCÊ ESCOLHEU {0} UNIDADE DE {1} TOTAL {2} R$", Quantidade, l9.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));

                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("CODIGO DO PRODUTO DIGITADO INEXISTENTE");
                }
                Console.WriteLine("----------------------------------------------\n\n-------------------\n");
                Console.Write("DESEJA FAZER OUTRO PEDIDO ? (S/N) ");
                Sair = Console.ReadLine();
                
                Console.Clear();
            } while (Sair == "S" || Sair == "s");

            Console.WriteLine("VOLTE SEMPRE E OBRIGADO PELA PREFERÊNCIA !");


            Console.ReadKey();
        }
    }

}
