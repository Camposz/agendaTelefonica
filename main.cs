using System;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AgendaMatheusF
{

    class main
    {
        static void Main(string[] args)
        {
            ListaCircular l1 = new ListaCircular();
            menu(l1);



        }

        public static void menu(ListaCircular l1)
        {
            Console.Clear();
            Console.Write("[Agenda Telefonica]\n");
            Console.Write("Digite o Numero de acordo com a função do menu desejada:\n");
            Console.Write("[1] - Adicionar contato\n");
            Console.Write("[2] - Remover contato\n");
            Console.Write("[3] - Editar contato\n");
            Console.Write("[4] - Procurar contato\n");
            Console.Write("[5] - Percorrer  contatos\n");
            Console.Write("[6] - Visualizar todos os contatos\n");
            Console.Write("[7] - Salvar em arquivo .txt\n");
            Console.Write("[8] - SAIR DO PROGRAMA\n");


            int escolhaMenu = Convert.ToInt32(Console.ReadLine());

            if (escolhaMenu == 1)
            {
                menu1(l1);

            }

            if (escolhaMenu == 2)
            {
                Console.Write(" Não consegui desenvolver uma lógica para exlcuir :/ \n");
                Console.Write("***Deseja voltar ao Menu***\n");
                Console.Write("1- [YES]            2- [NO]\n");
                int escolhasubMenu = Convert.ToInt32(Console.ReadLine());
                if (escolhasubMenu == 1)
                {
                    menu(l1);
                }
                else
                {
                    return;
                }

            }

            if (escolhaMenu == 3)
            {
                menu3(l1);
                Console.Write("***Deseja voltar ao Menu***\n");
                Console.Write("1- [YES]            2- [NO]\n");
                int escolhasubMenu = Convert.ToInt32(Console.ReadLine());
                if (escolhasubMenu == 1)
                {
                    menu(l1);
                }
                else
                {
                    return;
                }
            }

            if (escolhaMenu == 4)
            {
                menu4(l1);
                Console.Write("***Deseja voltar ao Menu***\n");
                Console.Write("1- [YES]            2- [NO]\n");
                int escolhasubMenu = Convert.ToInt32(Console.ReadLine());
                if (escolhasubMenu == 1)
                {
                    menu(l1);
                }
                else
                {
                    return;
                }

            }

            if (escolhaMenu == 5)
            {
                menu5(l1);
                Console.Write("***Deseja voltar ao Menu***\n");
                Console.Write("1- [YES]            2- [NO]\n");
                int escolhasubMenu = Convert.ToInt32(Console.ReadLine());
                if (escolhasubMenu == 1)
                {
                    menu(l1);
                }
                else
                {
                    return;
                }

            }

            if (escolhaMenu == 6)
            {
                l1.Print();
                Console.Write("***Deseja voltar ao Menu***\n");
                Console.Write("1- [YES]            2- [NO]\n");
                int escolhasubMenu = Convert.ToInt32(Console.ReadLine());
                if (escolhasubMenu == 1)
                {
                    menu(l1);
                }
                else
                {
                    return;
                }

            }

            if (escolhaMenu == 7)
            {
                l1.salvaLista();
                Console.Write("Arquivo salvo!\n");
                Console.Write("***Deseja voltar ao Menu***\n");
                Console.Write("1- [YES]            2- [NO]\n");
                int escolhasubMenu = Convert.ToInt32(Console.ReadLine());
                if (escolhasubMenu == 1)
                {
                    menu(l1);
                }
                else
                {
                    return;
                }

            }

            if (escolhaMenu == 8)
            {
                return;

            }
        }

        private static void menu5(ListaCircular l1)
        {
            l1.percorrerCotnatos();
        }


        private static void menu4(ListaCircular l1)
        {
            string procura;
            Console.Write("Digite o nome ou o email do contato que deseja encotnrar \n");
            procura = Console.ReadLine();
            l1.Procurar(procura);
        }

        private static void menu3(ListaCircular l1)
        {
            string contatoEditar, novoNome, novoTelefone, novoEmail;
            Console.Write("Digite o nome do cotnato que deseja editar: \n");
            contatoEditar = Console.ReadLine();
            Console.Write("Digite o novo nome, ou mantenha mantenha o mesmo: \n");
            novoNome = Console.ReadLine();
            Console.Write("Digite o novo Telefone, ou mantenha mantenha o mesmo: \n");
            novoTelefone = Console.ReadLine();
            Console.Write("Digite o novo E-mail, ou mantenha mantenha o mesmo: \n");
            novoEmail = Console.ReadLine();

            l1.Editar(contatoEditar, novoNome, novoTelefone, novoEmail);
            menu(l1);
        }


        public static void menu1(ListaCircular l1)
        {
            Console.Clear();
            Console.Write("Digite o nome do contato: \n");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do contato: \n");
            string telefone = Console.ReadLine();
            Console.Write("Digite o email do contato: \n");
            string email = Console.ReadLine();

            addContato(nome, telefone, email, l1);

            Console.Write("Contato adicionado!");
            menu(l1);


        }

        public static void addContato(string nome, string telefone, string email, ListaCircular lista)
        {
            lista.Add(new contatos() { nome = nome, telefone = telefone, email = email });
        }
    }
}

    
