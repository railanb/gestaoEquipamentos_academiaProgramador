
while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("╔═════════════════════════════════════╗");
    Console.WriteLine("║       CONTROLE DE EQUIPAMENTOS      ║");
    Console.WriteLine("╚═════════════════════════════════════╝");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("║ 1 - CADASTRAR EQUIPAMENTO           ║");
    Console.WriteLine("║ 2 - EDITAR EQUIPAMENTO              ║");
    Console.WriteLine("║ 3 - EXCLUIR EQUIPAMENT              ║");
    Console.WriteLine("║ 4 - VISUALIZAR EQUIPAMENTOS         ║");
    Console.WriteLine("║ S - SAIR                            ║");
    Console.WriteLine("╚═════════════════════════════════════╝");
    Console.Write("> ");

    string? opcaoMenu = Console.ReadLine()?.ToUpper();
    Console.ResetColor();

    if (opcaoMenu == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenu == "1")
    {
    }
}