namespace ATV2_CJ3021904
{
    internal class Program
    {
        static void Main(string[] args)
       
        
        
        
        
        {
            //Exercício 1
            float m, c, mm;

            Console.WriteLine("Exercécio 1- Digite um valor em metros: ");

            m = float.Parse(Console.ReadLine());

            c = (m * 100);

            mm = (c * 10);

            Console.WriteLine("centímetros = {0}", c);
            Console.WriteLine("milímetros = {0}", mm);

            //Exercício 2, a)

            float gf, gc;

            Console.WriteLine("Digite um valor em graus Fahrenheit: ");
            gf = float.Parse(Console.ReadLine());

            gc = (gf - 32.0f) * (5.0f / 9.0f);

            Console.WriteLine ("Graus Célcius = {0}", gc);

            //Exercécio 2, b)

            float f, c;

            Console.WriteLine("Digite um valor em graus Fahrenheit: ");
            f = float.Parse(Console.ReadLine());

            c = (f - 32) * (5 / 9);

            Console.WriteLine(" Da 0, pois float não pode receber um double. Graus Célcius = {0}", c);

            //Exercécio 3 

            float p, h, imc;

            Console.WriteLine("Digite seu peso: ");
            p = float.Parse(Console.ReadLine());
            Console.WriteLine ("Digite sua altura: ");
            h = float.Parse(Console.ReadLine());

            imc = (p / (h * h));

            Console.WriteLine ("IMC= {0}", imc);

            //Exercício 4

            float p1, p2, p3, i1, i2, i3, media;

            Console.WriteLine("Digite idade 1: ");
            i1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite idade 2: ");
            i2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite idade 3: ");
            i3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite peso 1: ");
            p1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite peso 2: ");
            p2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite peso 3: ");
            p3 = float.Parse(Console.ReadLine());

            media = ((i1 + i2 + i3) / (p1 * p2 * p3));

            Console.WriteLine ("Média Ponderada= {0}", media);

            //Exercício 5

            float d, t, v;

            Console.WriteLine("Digite um valor para distância: ");
            d = float.Parse(Console.ReadLine());    

            Console.WriteLine("Digite um valor para o tempo: ");
            t = float.Parse(Console.ReadLine());

            v = (d / t);

            Console.WriteLine ("Velocidade= {0}", v);

            
            //Exeercício 6

            float salario;

            Console.WriteLine("Exercício 6- Digite seu salário: ");

            salario = float.Parse(Console.ReadLine());

            salario = salario + (25.0f / 100.0f) * salario;

            Console.WriteLine("O novo salário é R${0}", salario);

            //Exercício 7

            float real, cota, doll;

            Console.WriteLine("Digite um valor em real: ");
            real = float.Parse(Console.ReadLine());

            Console.WriteLine ("Digite um valor da cotação: ");
            cota = float.Parse(Console.ReadLine());

            doll = (real * cota);

            Console.WriteLine("O valor em Dóllar é de U${0}", doll);



            
            //Exercício 8
            int n;

            Console.WriteLine("Digite um número: ");

            n = int.Parse(Console.ReadLine());

            n = (((n * 3) + 1) + ((n * 2) - 1));


            Console.WriteLine("O resultado é {0} ", n);



            //Exercécio 10
            float bolsa;

            bolsa = 1000f;
            

            bolsa = (bolsa - ((bolsa / 100f) * 3.4f));
            bolsa = (bolsa + ((bolsa / 100f) * 2.8f));
            bolsa = (bolsa + ((bolsa / 100f) * 14f));
            bolsa = (bolsa - ((bolsa / 100f) * 8.5f));

            Console.WriteLine("O valor atual dos investimentos é de R${0}", bolsa);







            

            
        }

       

    

        
        
    }
}
