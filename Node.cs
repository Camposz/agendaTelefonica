using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaMatheusF
{
    public class Node
    {
        public contatos data;
        public Node next;

        public Node()
        {
            data = null;
            next = null;
        }

        public Node(contatos contato)
        {
            data = contato;
            next = null;
        }
    }
}
