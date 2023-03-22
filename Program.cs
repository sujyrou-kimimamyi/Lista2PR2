using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Exercicio 1
            double nl, vc, vs, t;

            vc = 0.28;
            vs = 0.35;

            Console.WriteLine("Digite o número de laranjas que deseja comprar. ");
            nl = double.Parse(Console.ReadLine());

            if (nl >= 12)
                t = nl * vc;

            else
                t = nl * vs;

            Console.WriteLine("0 valor total da compra é igual a: " + t);
            Console.ReadKey();
            */

            /*Exercicio 2
            int a, an, i, im;

            im = 16;

            Console.WriteLine("Digite o ano em que você nasceu. ");
            an = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano em que você está. ");
            a = int.Parse(Console.ReadLine());

            i = a - an;

            if (i < im)
                Console.WriteLine("Você não poderá votar este ano.");

            else if (i >= im)
                Console.WriteLine("Você poderá votar este ano.");

            Console.ReadKey();
            */

            /*Exercicio 3
            
            double l1, l2, l3;

            Console.WriteLine("Digite o primeiro lado do triângulo. ");
            l1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triângulo. ");
            l2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triângulo. ");
            l3 = double.Parse(Console.ReadLine());

            if ((l1 == l2) && (l2 == l3))
                Console.WriteLine("Seu triângulo é equilátero. ");

            else if ((l1 == l3) || (l2 == l3) || (l1 == l2))
                Console.WriteLine("Seu triângulo é isósceles. ");

            else
                Console.WriteLine("Seu triângulo é escaleno. ");

            Console.ReadKey();
            */

            /*Exercicio 4

            double a, b, c, d, r1, r2;

            Console.WriteLine("Digite o valor dos coeficientes a, b e c, respectivamente. ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            d = (b * b) - 4 * a * c;

            r1 = (-b + (Math.Sqrt(d))) / (2 * a);
            r2 = (-b - (Math.Sqrt(d))) / (2 * a);

            Console.WriteLine("A raiz 1 é igual a: " + r1);
            Console.WriteLine("A raiz 2 é igual a: " + r2);

            Console.ReadKey();

            */

            /*Exercício 5

            int n;

            Console.WriteLine("Digite um número. ");
            n = int.Parse(Console.ReadLine());

            if ((n % 5) == 0)
                Console.WriteLine("Este número é divisível por 5. ");

            else if ((n % 3) == 0)
                Console.WriteLine("Este número é divisível por 3. ");

            else
                Console.WriteLine("Este número não é divisível nem por 3, nem por 5. ");

            Console.ReadKey();

            */

            /*Exercicio 6

            double a1, a2, a3;

            Console.WriteLine("Escreva os 3 ângulos do seu triângulo. ");
            a1 = double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            a3 = double.Parse(Console.ReadLine());

            if ((a1 == 90) || (a2 == 90) || (a3 == 90))
                Console.WriteLine("Seu triângulo é um triângulo retângulo. ");

            else if ((a1 > 90) || (a2 > 90) || (a3 > 90))
                Console.WriteLine("Seu triângulo é um triângulo obtusângulo. ");

            else if ((a1 > 90) && (a2 > 90) && (a3 > 90))
                Console.WriteLine("Seu triângulo é um triângulo acutângulo. ");

            Console.ReadKey();

            */

            /*Exercicio 7
            
            int n1, n2, n3;

            Console.WriteLine("Escreva 3 números inteiros, sem repetir nenhum. ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if ((n1 < n2 && n2 < n3))
                Console.WriteLine(n1 + " " + n2 + " " + n3);

            else if (n1 < n2 && n2 > n3 && n3 > n1)
                Console.WriteLine(n1 + " " + n3 + " " + n2);

            else if (n2 < n1 && n1 < n3)
                Console.WriteLine(n2 + " " + n1 + " " + n3);

            else if (n2 < n1 && n3 < n1 && n2 < n3)
                Console.WriteLine(n2 + " " + n3 + " " + n1);

            else if (n3 < n1 && n1 < n2)
                Console.WriteLine(n3 + " " + n1 + " " + n2);

            else if (n3 < n2 && n2 < n1 && n3 < n2)
                Console.WriteLine(n3 + " " + n2 + " " + n1);

            Console.ReadKey();  

            */

            /*Exercicio 8

            int ano;

            Console.WriteLine("Digite um ano. ");
            ano = int.Parse(Console.ReadLine());

            if ((ano % 4) == 0)
                Console.WriteLine("Seu ano é bissexto. ");

            else
                Console.WriteLine("Seu ano não é bissexto. ");

            Console.ReadKey();

            */

            /*Exercicio 9
            double n1, n2, r;
            string op;

            Console.WriteLine("Digite dois números, respectivamente. ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação que deseja realizar. ");
            op = Console.ReadLine();

            r = 0;

            if (op == "+")
                r = n1 + n2;

            else if (op == "-")
                r = n1 - n2;

            else if (op == "*")
                r = n1 * n2;

            else if (op == "/")
                r = n1 / n2;

            Console.WriteLine("O resultado da operação é igual a " + r);
            Console.ReadKey();

            */

            

            /*Exercicio 10:
              
            Para gerar números aleatórios em c#, basta usar a classe random.
            
            Random randNum = new Random();
            randNum.Next();

            */

        }
    }
}