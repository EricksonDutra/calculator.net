// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("What do you want?");

    Console.WriteLine("1 - Sum \n2 - Sub \n3 - Div \n4 - Mult");
    Console.WriteLine("##########################");

    Console.Write("Select a option: ");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        default: Menu(); break;
    }

}

static void Soma(){
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    // Console.WriteLine("A soma é "+ resultado );
    float resultado = v1+v2;
    Console.WriteLine($"A soma de {v1} + {v2} = {resultado}.");
    Console.ReadKey();
    Menu();
}

static void Subtracao(){
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    
    float resultado = v1-v2;
    Console.WriteLine($"A subtração de {v1} - {v2} = {resultado}.");
    Console.ReadKey();
    Menu();
}

static void Divisao(){

    Console.Clear();

    Console.WriteLine("Primeiro valor");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    if (v2 != 0)
    {
        float resultado = v1 / v2;
        Console.WriteLine($"A divisão de {v1} / {v2} = {resultado}.");
    }
    else
    {
        Console.WriteLine($"Não é possível divisão por {v2}");    
    }
    Console.ReadKey();
    Menu();
}

static void Multiplicacao(){
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;

    Console.WriteLine("");
    Console.WriteLine($"A multiplicação de {v1} * {v2} = {resultado}");
    
    Console.ReadKey();
    Menu();
}