namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a limitação de area: "); //5 5
            string[] coordenadas = Console.ReadLine().Split(' ');
            int xMax = int.Parse(coordenadas[0]);
            int yMax = int.Parse(coordenadas[1]);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Digite a posição inicial do Robô {i + 1}: "); //1 2 N
                string[] entrada = Console.ReadLine().Split(' ');
                int x = int.Parse(entrada[0]);
                int y = int.Parse(entrada[1]);
                string direcao = (entrada[2]).ToUpper();

                Console.WriteLine($"Informe as direções a serem realizadas pelo Robô {i + 1}: "); //direçoes 
                Console.WriteLine("E para virar a esquerda, D para virar a direita, e M para se deslocar.");
                string comando = Console.ReadLine().ToUpper();
                char[] comandos = comando.ToCharArray();

                // Loop para executar as instruções do robô
                foreach (char c in comandos)
                {
                    // Executa a instrução correspondente
                    if (c == 'E')
                    {
                        direcao = GirarEsquerda(direcao);
                    }
                    else if (c == 'D')
                    {
                        direcao = GirarDireita(direcao);
                    }
                    else if (c == 'M')
                    {
                        (int valorX, int valorY) = Andar(x, y, direcao);
                        x = valorX;
                        y = valorY;
                    }
                }
                Console.WriteLine($"A posição atual do Robô {i + 1} é: {x},{y},{direcao}");
            }
            
        }


        static (int, int) Andar(int x, int y, string direcao)
        {
            switch (direcao)
            {
                case "N":
                    y += 1;
                    return (x, y);
                case "L":
                    x += 1;
                    return (x, y);
                case "S":
                    y -= 1;
                    return (x, y);
                case "O":
                    x -= 1;
                    return (x, y);
                default:
                    Console.WriteLine("Não foi possível concluir operação.");
                    return (x, y);
            }
        }

        static string GirarDireita(string direcao)
        {
            switch (direcao)
            {
                case "N":
                    direcao = "L";
                    return direcao;
                case "L":
                    direcao = "S";
                    return direcao;
                case "S":
                    direcao = "O";
                    return direcao;
                case "O":
                    direcao = "N";
                    return direcao;

                default:
                    return direcao;
            }
        }
        public static string GirarEsquerda(string direcao)
        {
            switch (direcao)
            {
                case "N":
                    direcao = "O";
                    return direcao;
                case "O":
                    direcao = "S";
                    return direcao;
                case "S":
                    direcao = "L";
                    return direcao;
                case "L":
                    direcao = "N";
                    return direcao;
                default:
                    return direcao;

            }
        }
    }
}