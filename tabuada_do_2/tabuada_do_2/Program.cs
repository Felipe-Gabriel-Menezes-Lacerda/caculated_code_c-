// See https://aka.ms/new-console-template for more information

static void whatDoYouWannaDo()
{
    Console.WriteLine("Selecione uma opção");
    Console.WriteLine("Opção 1: Ter a tabuada de um número");
    Console.WriteLine("Opção 2: Calcular a área de um triângulo qualquer");
    Console.WriteLine("Opção 3: Fazer a divisão de um número");
    Console.Write("Digite o número correspondente à opção: ");
    

    string optionSelected = Console.ReadLine();

    if (optionSelected != "")
    {
        switch (optionSelected)
        {
            case "1":
                Console.WriteLine("Então vamos calcular a tabuada de um número");
                Multiplication_table_2();
                break;
            case "2":
                Console.WriteLine("Vamos calcular a área de um triângulo");
                triangleAreaCalculate();
                break;
            case "3":
                DivisionNumber();

                break;
            default:
                Console.WriteLine("Hm..., que curioso a opção selecionada não realiza nenhuma ação específica, vamos tentar novamente");
                whatDoYouWannaDo();
                break;

                    

        }
    } else
    {
        Console.WriteLine("Opção inválida tente novamente");
        whatDoYouWannaDo();
    }

}

static void Multiplication_table_2()
{   
    

    Console.WriteLine("Programa para verificar a tabuada de um número");
    Console.Write("Digite o número para ver a sua tabuada:");
    string user_answer = Console.ReadLine();

    if(user_answer != "")
    {
        int num_multiplication_table = int.Parse(user_answer);

        if (num_multiplication_table >= 1)
        {
            for (int table_item = 1; table_item < 11; table_item++)
            {
                Console.WriteLine(
                    $"{num_multiplication_table}x{table_item} = {num_multiplication_table * table_item}"
                    );
            }
        }
        else
        {
            Console.WriteLine("Insira um valor válido");
        }

    } else
    {
        Console.WriteLine("Insira algum valor númerico para executar o programa");
    }  
    
}

static void triangleAreaCalculate()
{
    Console.WriteLine("para calcular a área de um tiângulo, é necessário os valores de sua base e de sua altura");
    Console.Write("Digite o valor da medida da base do triângulo:");
    int triangle_base = int.Parse(Console.ReadLine());

    if(triangle_base/triangle_base == 1)
    {
        Console.Write("digite o valor da medida da altura do triangulo:");
        int triangle_high = int.Parse(Console.ReadLine());

        if(triangle_high/triangle_high == 1)
        {
            Console.WriteLine("Calculando área do triangulo...");

            int result_count = (triangle_base *triangle_high)/2 ;

            Console.WriteLine("A área do triângulo é: {0}", result_count );
        }

    }
    else
    {
        Console.WriteLine("Digite um valor válido \n");
        triangleAreaCalculate();

    }

}

static void DivisionNumber()
{
    int numDivisor = 0;
    int numDividend = 0;
    Console.Write("Digite o número que você deseja dividir: ");
    numDividend = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite a quantidade de vezes que ele precisa ser dividido: ");
    numDivisor = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("O cosciente de {0} por {1} é igual a {2}", numDividend, numDivisor, (numDividend/numDivisor));
    Console.WriteLine($"O resto da divisão de {numDividend} por {numDivisor} é: {numDividend%numDivisor}");

}

whatDoYouWannaDo();
Console.ReadLine();