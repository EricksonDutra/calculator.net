// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("*#>>  CALCULATOR  <<#*");

    Console.WriteLine("0 - Exit\n1 - Sum \n2 - Sub \n3 - Div \n4 - Mult\n");
    Console.WriteLine("##########################");

    Console.Write("Select a option: ");
    short res = short.Parse(Console.ReadLine());
    
    if (res == 0)
    {
        System.Environment.Exit(0);
    }

    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    switch (res)
    {
        // case 0: System.Environment.Exit(0); break;
        case 1: Soma(v1, v2); break;
        case 2: Subtracao(v1, v2); break;
        case 3: Divisao(v1, v2); break;
        case 4: Multiplicacao(v1, v2); break;
        default: Menu(); break;
    }

}

static void Soma(float n1, float n2){
    float resultado = n1+n2;
    Console.WriteLine($"A soma de {n1} + {n2} = {resultado}.");
    Console.ReadKey();
    Menu();
}

static void Subtracao(float n1, float n2){   
    float resultado = n1-n2;
    Console.WriteLine($"A subtração de {n1} - {n2} = {resultado}.");
    Console.ReadKey();
    Menu();
}

static void Divisao(float n1, float n2){
    Console.WriteLine("");
    if (n2 != 0)
    {
        float resultado = n1 / n2;
        Console.WriteLine($"A divisão de {n1} / {n2} = {resultado}.");
    }
    else
    {
        Console.WriteLine($"Não é possível divisão por {n2}");    
    }
    Console.ReadKey();
    Menu();
}

static void Multiplicacao(float n1, float n2){
    float resultado = n1 * n2;

    Console.WriteLine("");
    Console.WriteLine($"A multiplicação de {n1} * {n2} = {resultado}");
    
    Console.ReadKey();
    Menu();
}