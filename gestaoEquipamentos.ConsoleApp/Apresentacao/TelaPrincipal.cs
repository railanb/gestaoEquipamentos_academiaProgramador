using System;

namespace gestaoEquipamentos.ConsoleApp.Apresentacao;

public class TelaPrincipal
{
	public string ObterOpcaoMenuPrincial()
	{
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔═════════════════════════════════════╗");
        Console.WriteLine("║       GESTÃO DE EQUIPAMENTOS        ║");
        Console.WriteLine("╚═════════════════════════════════════╝");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("║ 1 - CONTROLE DE EQUIPAMENTS         ║");
        Console.WriteLine("║ 2 - CONTROLE DE CHAMADOS            ║");
        Console.WriteLine("║ S - SAIR                            ║");
        Console.WriteLine("╚═════════════════════════════════════╝");
        Console.Write("> ");

        string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

        return opcaoMenuPrincipal;
    }
}
