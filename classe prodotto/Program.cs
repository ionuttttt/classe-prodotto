using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace classe_prodotto
{
    internal class Program
    {
        class prodotto
        {
            protected string nome;
            protected float prezzo;

            public prodotto()
            {
                nome = "farro";
                prezzo = 10;
            }

            public prodotto(string nome, float prezzo)
            {
                this.nome = nome;
                this.prezzo = prezzo;
            }
            public void Scrivi()
            {
                Console.WriteLine(nome + " costa " + prezzo);
            }


        }
        static void Main(string[] args)
        {
            prodotto prod=new prodotto();
            prod.Scrivi();
            prodotto prod1 = new prodotto("casa",50);
            prod1.Scrivi();
            Console.ReadLine();


        }
    }
}
