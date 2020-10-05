using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.IO;

namespace AgendaMatheusF
{
    public class ListaCircular
    {
        public Node head;

        public ListaCircular()
        {
            head = null;
        }

        public void Add(contatos contato)
        {
            Node aux = head;
            var newNode = new Node(contato);
            if (head != null)
            {
                while (aux.next != head)
                {
                    aux = aux.next;
                }
            }
            else
            {
                aux = newNode;
            }


            newNode.next = head;
            head = newNode;
            aux.next = head;
        }

        public void Print()
        {
            Console.Clear();
            var aux = head;
            if (head == null)
            {
                
                Console.Write("[LISTA VAZIA]\n\n");
            }
            else
            {
                
                do
                {
                    Console.Write($" Nome ->[{aux.data.nome}]");
                    Console.Write($" Telefone ->[{aux.data.telefone}]");
                    Console.Write($" Email ->[{aux.data.email}]\n");
                    aux = aux.next;
                } while (aux != head);
            }
        }

        public void Editar(string contatoEditar, string novoNome, string NovoTelefone, string novoEmail)
        {
            var aux = head;
            if (head == null)
            {
                Console.Clear();
                Console.Write("[LISTA VAZIA]\n\n");
            }

            else
            {
                do
                {
                    if (aux.data.nome == contatoEditar)
                    {
                        aux.data.nome = novoNome;
                        aux.data.telefone = NovoTelefone;
                        aux.data.email = novoEmail;

                    }
                    aux = aux.next;
                } while (aux != head);
            }
        }

        public void Procurar(string procura)
        {
            var aux = head;
            if (head == null)
            {
                Console.Clear();
                Console.Write("[LISTA VAZIA]\n\n");
            }

            else
            {
                do
                {
                    if (aux.data.nome == procura || aux.data.email == procura)
                    {
                        Console.Write($" Nome ->[{aux.data.nome}]");
                        Console.Write($" Telefone ->[{aux.data.telefone}]");
                        Console.Write($" Email ->[{aux.data.email}]\n");
                    }

                    aux = aux.next;
                } while (aux != head);
            }

        }

        public void percorrerCotnatos()
        {
            int irvoltar;
            var aux = head;
            if (head == null)
            {
                Console.Clear();
                Console.Write("[LISTA VAZIA]\n\n");
            }

            else
            {
                do
                {

                    Console.Write($" Nome ->[{aux.data.nome}]");
                    Console.Write($" Telefone ->[{aux.data.telefone}]");
                    Console.Write($" Email ->[{aux.data.email}]\n");
                    Console.Write("---Digite 1 Para ir para o Próximo, caso queira sair digite qualquer outra coisa------\n");
                    irvoltar = Convert.ToInt32(Console.ReadLine());
                    if (irvoltar == 1)
                    {
                        Console.Clear();
                        aux = aux.next;
                    }
                    else
                    {
                        return;
                    }
                } while (true == true);
            }
        }

        public  void salvaLista()
        {
            var aux = head;
            string pasta_doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_pasta = pasta_doc + @"\pasta_contatos.txt";
            if (!File.Exists(nome_pasta))
            {
                // Cria o arquivo caso nao exista
                using (StreamWriter sw = File.CreateText(nome_pasta))
                {
                    
                    if (head == null)
                    {
                        Console.Clear();
                        Console.Write("[LISTA VAZIA]\n\n");
                    }

                    else
                    {
                        do
                        {
                            sw.WriteLine(aux.data.nome);
                            sw.WriteLine(aux.data.telefone);
                            sw.WriteLine(aux.data.email);
                            aux = aux.next;
                        } while (aux != head);
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(nome_pasta, false, Encoding.Default))
                {
                    if (head == null)
                    {
                        Console.Clear();
                        Console.Write("[LISTA VAZIA]\n\n");
                    }

                    else
                    {
                        do
                        {
                            sw.WriteLine(aux.data.nome);
                            sw.WriteLine(aux.data.telefone);
                            sw.WriteLine(aux.data.email);
                            aux = aux.next;
                        } while (aux != head);
                    }
                }
            }
        }

    }
}
