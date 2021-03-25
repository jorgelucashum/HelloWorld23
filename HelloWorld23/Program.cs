using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld23
{
    class Program
    {
        // Funções interessantes para o 'string':
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            int n1 = original.IndexOf("bc"); // '.IndexOf' Procura a posição do valor no parâmetro.
            int n2 = original.LastIndexOf("bc"); // '.LastIndexOf' Procura a última posição do valor no parâmetro.


            string s1 = original.ToUpper(); // '.ToUpper' Converte todo 'string' para maiúsculo.
            string s2 = original.ToLower(); // '.ToLower' Convete todo 'string' para minusculo.
            string s3 = original.Trim(); // '.Trim' Apaga os espaços em brancos somente antes e depois da 'string'.

            string s4 = original.Substring(3); // '.Substring' Recorta uma parte de um 'string', nesse caso recorta a partir da posiçao '3'.
            string s5 = original.Substring(3, 5); //  Nesse caso recorta a partir da posiçao '3' e para na '5'.

            string s6 = original.Replace('a', 'x'); // '.Replace' faz a troca de um caractere ou um 'string'. Nesse caso irá trocar todo 'a' pelo 'x'.
            string s7 = original.Replace("abc", "XY"); // Nesse caso irá trocar todo "abc" pelo 'XY'.
            string[] s8 = original.ToString().Split(' '); // '.ToString().Split(' ')' separa os valores baseado no parametro do '.Split' para um array, nesse caso o '(' ')'.

            bool b1 = String.IsNullOrEmpty(original); // '.IsNullOrEmpty' Testa se o conteúdo da varíavel do parâmetro é 'null' ou vazia. // Bom para verificar dados no fomurlários
            bool b2 = String.IsNullOrWhiteSpace(original); // '.IsNullOrWhiteSpace' Testa se o conteúdo da varíavel do parâmetro é 'null' ou ´contém espaços em branco.


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("Substring('3'): " + s4);
            Console.WriteLine("Substring('3, 5'): " + s5);
            Console.WriteLine("Replace('a', 'x'): " + s6);
            Console.WriteLine("Replace('abc', 'XY'): " + s7);
            Console.WriteLine("ToString().Split(' '): " + s8[0]+ " " + s8[1] + " " + s8[2]);
            Console.WriteLine("IsNullOrEmpt: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);



        }
    }
}
