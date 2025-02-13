using System.Globalization;
namespace course
{
    class Program{ 
        static void Main(string[] args) {
            //aula1();
            //aula2();
            //aula3();
            //aula4();
            //aula5();
            //aula6();
            //exercicio1();
            //aula7();

        }

        static void aula1 (){
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("----------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome,idade,saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais ");
            Console.WriteLine(nome + " tem " +  idade  + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");
        }
        static void aula2()
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 10;
            c--;
            Console.WriteLine(c);

            int d = b++;
            Console.WriteLine(d);
        }
        static void aula3()
        {
            int a = 5;
            int b = 2;

            double resultado = a / b;

            Console.WriteLine(resultado);

        }
        static void aula4() {

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            double n4 = (double) 10 / 8;
            Console.WriteLine(n4);

            double a = 1.0, b =-3.0, c = -4.0;

            double delta = Math.Pow(b,2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);

        }
        static void aula5 () { 

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];




            Console.WriteLine("Você digitou");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            


        }
        static void aula6(){

            int n1= int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você Digitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

       }   

        static void exercicio1(){

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos carros existem na sua casa");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double prod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string nomemeio= vet[0];
            int idade = int.Parse(vet[1]);
            double altura= double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(prod);
            Console.WriteLine(nomemeio);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
        static void aula7(){

            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("-----------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);


        }


    }
}