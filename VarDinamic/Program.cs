using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 12345;
            t2 = "";

            var v1 = "";
            var v2 = 12345;
            //v2 = ""; v2 não pode receber string

            //variaveis dynamic permite ser declarado e ser usada apenas em runtime  
            dynamic d1 = new Usuario { Nome = "Tiago" };

            Console.WriteLine(d1.Nome);
            //permite acessar objetos mesmo que não esteja estruturado
            //Console.WriteLine(d1.Senha);
            //perimte ser trocado
            d1 = "";

            Console.ReadKey();
        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
