namespace ATV2_CJ3021904
{
    internal class Program
    {
        static void Main(string[] args)
       
        
        
        
        
        {
            float bolsa;

            bolsa = 1000f;
            

            bolsa = (bolsa - ((bolsa / 100f) * 3.4f));
            bolsa = (bolsa + ((bolsa / 100f) * 2.8f));
            bolsa = (bolsa + ((bolsa / 100f) * 14f));
            bolsa = (bolsa - ((bolsa / 100f) * 8.5f));

            Console.WriteLine("Exercício 1- O valor atual dos investimentos é de R${0}", bolsa);




            float salario;

            Console.WriteLine("Exercício 2- Digite seu salário: ");

            salario = float.Parse( Console.ReadLine() );

            salario = salario + (25.0f / 100.0f) * salario;

            Console.WriteLine("O novo salário é R${0}", salario);



            int n;
           
            Console.WriteLine("Exercício 3- Digite um número: ");

            n = int.Parse( Console.ReadLine() );

            n = (((n * 3) + 1) + ((n * 2) - 1));


            Console.WriteLine("O resultado é {0} ", n);

            
        }

       

    

        
        
    }
}
