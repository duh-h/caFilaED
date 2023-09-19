using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaED
{
    internal class Fila
    {
        public Noh Head { get; set; }


        public Fila()
        {
            this.Head = new Noh(0);
            this.Head.anterior = null;
            this.Head.proximo = null;
        }

        public void addFim(int info)
        {
            Noh novoNoh = new Noh(info);

            if (this.Head.anterior == null)
            {
                this.Head.anterior = novoNoh;
                this.Head.proximo = novoNoh;
            }
            else
            {
                novoNoh.anterior = this.Head.proximo;
                this.Head.proximo.proximo = novoNoh;
                this.Head.proximo = novoNoh;
            }

        }
        public void removeInicio()
        {



            Head.anterior.proximo.anterior = null;
            Head.anterior = Head.anterior.proximo;
        }



        public void Imprimirlista()
        {
            Noh atual = Head.anterior;

            while (atual != null)
            {
                Console.WriteLine(atual.info);
                atual = atual.proximo;
            }

            Console.WriteLine();
        }
        public int Remove()
        {
            return Head.proximo.info;
        }

        public void InsirirLugar(int info)
        {
            Noh atual = Head.anterior;
            Noh novo = new Noh(info);

            while (atual.info != info)
            {
                atual = atual.proximo;
            }
            novo.proximo = atual.proximo;
            atual.proximo.anterior= novo;
            atual.proximo = novo;
            novo.anterior = atual;
            novo.info = Convert.ToInt32(Console.ReadLine());


        }

       
      

    }
}

