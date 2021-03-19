using System;

namespace MemoriaTela
{
    class Program
    {
        static void Main(string[] args)
        {
            double resolucao_horizontal = 0;
            double resolucao_vertical = 0;
            double bits_pixel = 0;
            int count = 0;

            string[] tipo_memoria = new string[2] {"Kbytes", "Mbytes"};

            System.Console.Write("Digite a resolução horizontal: ");
            resolucao_horizontal = double.Parse(Console.ReadLine());
            System.Console.Write("Digite a resolução vertical: ");
            resolucao_vertical = double.Parse(Console.ReadLine());
            Console.Write("Digite a densidade de píxel por bits: ");
            bits_pixel = double.Parse(Console.ReadLine());

            for (double potencia = 1; potencia < resolucao_horizontal;potencia++)
            {
                double resultado = Math.Pow(2,potencia);
                if(resultado > resolucao_horizontal){
                    resolucao_horizontal = resultado;
                    break;
                }
            }

            for (double potencia = 1; potencia < resolucao_vertical; potencia++)
            {
                double resultado = Math.Pow(2, potencia);
                if (resultado > resolucao_vertical)
                {
                    resolucao_vertical = resultado;
                    break;
                }
            }
            double total = resolucao_horizontal * resolucao_vertical * bits_pixel;
            Console.WriteLine($"Bits: {total}");
            total = total / 8;
            Console.WriteLine($"Bytes {total}");
            while(total > 1024)
            {
                total = total / 1024;
                Console.WriteLine($"{tipo_memoria[count]}: {total}");
                count++;
            }
            Console.WriteLine("Fim");
        }
    }
}
