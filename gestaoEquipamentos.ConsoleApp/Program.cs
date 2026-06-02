
using System.Data;
using gestaoEquipamentos.ConsoleApp.Dominio;


int contadorIds = 1;
Equipamento[] equipamentosSalvos = new Equipamento[100];

int contadorIdsChamados = 1;
Chamado[] chamadosSalvos = new Chamado[100];

/*EQUIPAMENTO DE TESTE*/
Equipamento equipamentoTeste = new Equipamento();
equipamentoTeste.id = contadorIds++;
equipamentoTeste.nome = "Notebook Dell";
equipamentoTeste.precoAquisicao = 4000;
equipamentoTeste.dataFabricacao = DateTime.Parse("02/02/2022");

Equipamento equipamentoTeste1 = new Equipamento();
equipamentoTeste1.id = contadorIds++;
equipamentoTeste1.nome = "Monitor AOC";
equipamentoTeste1.precoAquisicao = 890;
equipamentoTeste1.dataFabricacao = DateTime.Parse("19/07/2025");

equipamentosSalvos[0] = equipamentoTeste;
equipamentosSalvos[1] = equipamentoTeste1;


while (true)
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

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenuPrincipal == "1")
    {


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
            Console.WriteLine("║ 3 - EXCLUIR EQUIPAMENTO             ║");
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

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═══════════════════════════════╗");
                Console.WriteLine("║ CADASTRO DE EQUIPAMENTOS      ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.ResetColor();

                Console.Write(">> Digite o nome do equipamento: ");
                string nome = Console.ReadLine();

                Console.Write(">> Digite o preço de aquisição do equipamento: ");
                decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

                Console.Write(">> Digite a data de fabricação do equipamento: ");
                DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                Equipamento equipamento = new Equipamento();
                equipamento.id = contadorIds++;
                equipamento.nome = nome;
                equipamento.precoAquisicao = precoAquisicao;
                equipamento.dataFabricacao = dataFabricacao;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    if (equipamentosSalvos[i] == null)
                    {
                        equipamentosSalvos[i] = equipamento;
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($">> O equipamento {equipamento.nome} foi cadastrado com sucesso!");
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();

            }

            else if (opcaoMenu == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ EDITAR DE EQUIPAMENTOS                                              ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();


                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                    );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                    {
                        continue;
                    }
                    Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
                    );

                }

                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.Write(">> Digite o ID do registro que deseja editar: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                Console.Write(">> Digite o nome do equipamento: ");
                string nome = Console.ReadLine();

                Console.Write(">> Digite o preço de aquisição do equipamento: ");
                decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

                Console.Write(">> Digite a data de fabricação do equipamento: ");
                DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];

                    if (equipamentoSelecionado == null)
                        continue;

                    if (equipamentoSelecionado.id == idSelecionado)
                    {
                        equipamentoSelecionado.nome = nome;
                        equipamentoSelecionado.precoAquisicao = precoAquisicao;
                        equipamentoSelecionado.dataFabricacao = dataFabricacao;
                        break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($">> O equipamento {nome} foi atualizado com sucesso!");
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();

            }

            else if (opcaoMenu == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ EXCLUSÃO DE EQUIPAMENTOS                                            ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();

                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                    );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                    {
                        continue;
                    }
                    Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
                    );

                }


                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.Write(">> Digite o ID do registro que deseja excluir: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];

                    if (equipamentoSelecionado == null)
                    {
                        continue;
                    }

                    if (equipamentoSelecionado.id == idSelecionado)
                    {
                        equipamentosSalvos[i] = null;
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($">> O equipamento foi excluido com sucesso!");
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();

            }

            else if (opcaoMenu == "4")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ VISUALIZAÇÃO DE EQUIPAMENTOS                                        ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();


                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                    );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                    {
                        continue;
                    }
                    Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
                    );

                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();
            }

        }

    }

    else if (opcaoMenuPrincipal == "2")
    {
        while (true)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║       CONTROLE DE CHAMADOS          ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("║ 1 - CADASTRAR CHAMADO               ║");
            Console.WriteLine("║ 2 - EDITAR CHAMADO                  ║");
            Console.WriteLine("║ 3 - EXCLUIR CHAMADO                 ║");
            Console.WriteLine("║ 4 - VISUALIZAR CHAMADO              ║");
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

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═══════════════════════════════╗");
                Console.WriteLine("║ CADASTRO DE CHAMADOS          ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.ResetColor();

                Console.Write(">> Digite o titulo do chamado: ");
                string titulo = Console.ReadLine();

                Console.Write(">> Digite a descrição do chamado: ");
                string descricao = Console.ReadLine();

                DateTime dataAbertura = DateTime.Now;


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.ResetColor();


                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                    );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                    {
                        continue;
                    }
                    Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
                    );

                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.ResetColor();

                Console.Write(">> Digite o ID do equipamento que deseja selecionar: ");
                int idEquipamentoSelecionado = Convert.ToInt32(Console.ReadLine());

                Equipamento equipamentoSelecionado = null;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];
                    if (eq == null)
                        continue;

                    if (eq.id == idEquipamentoSelecionado)
                    {
                        equipamentoSelecionado = eq;
                        break;
                    }
                }

                Chamado novoChamado = new Chamado();
                novoChamado.id = contadorIdsChamados++;
                novoChamado.titulo = titulo;
                novoChamado.descricao = descricao;
                novoChamado.dataAbertura = dataAbertura;
                novoChamado.equipamento = equipamentoSelecionado;

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    if (chamadosSalvos[i] == null)
                    {
                        chamadosSalvos[i] = novoChamado;
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($">> O chamado {novoChamado.titulo} foi cadastrado com sucesso!");
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();
            }
            else if (opcaoMenu == "2")
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═══════════════════════════════╗");
                Console.WriteLine("║    EDIÇÃO DE CHAMADOS         ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.ResetColor();


                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -30} ║ {3, -17} ║ {4, -15}",
                    "Id", "Título", "Descrição", "Data de Abertura", "Equipamento"
                );

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado ch = chamadosSalvos[i];
                    if (ch == null)
                        continue;


                    Console.WriteLine(
                        "{0, -7} ║ {1, -15} ║ {2, -30} ║ {3, -17} ║ {4, -15}",
                        ch.id, ch.titulo, ch.descricao, ch.dataAbertura.ToShortDateString(), ch.equipamento.nome
                    );
                }

                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.Write(">> Digite o ID do registro que deseja editar: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o titulo do chamado: ");
                string titulo = Console.ReadLine();


                Console.Write("Digite a descrição do chamado: ");
                string descricao = Console.ReadLine();


                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                    );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                    {
                        continue;
                    }
                    Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -20} ║ {3, -15}",
                    eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
                    );

                }


                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.Write(">> Digite o ID do equipamento que deseja selecionar: ");
                int idEquipamentoSelecionado = Convert.ToInt32(Console.ReadLine());

                Equipamento equipamentoSelecionado = null;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                        continue;

                    if (eq.id == idEquipamentoSelecionado)
                    {
                        equipamentoSelecionado = eq;
                        break;
                    }
                }

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado chamadoSelecionado = chamadosSalvos[i];

                    if (chamadoSelecionado == null)
                        continue;

                    if (chamadoSelecionado.id == idSelecionado)
                    {
                        chamadoSelecionado.titulo = titulo;
                        chamadoSelecionado.descricao = descricao;
                        chamadoSelecionado.equipamento = equipamentoSelecionado;
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($">> O chamado {titulo} foi atualizado com sucesso!");
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();

            }
            else if (opcaoMenu == "3")
            {


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═══════════════════════════════╗");
                Console.WriteLine("║    EXCLUSÃO DE CHAMADOS       ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.ResetColor();


                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -30} ║ {3, -17} ║ {4, -15}",
                    "Id", "Título", "Descrição", "Data de Abertura", "Equipamento"
                );

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado ch = chamadosSalvos[i];
                    if (ch == null)
                        continue;


                    Console.WriteLine(
                        "{0, -7} ║ {1, -15} ║ {2, -30} ║ {3, -17} ║ {4, -15}",
                        ch.id, ch.titulo, ch.descricao, ch.dataAbertura.ToShortDateString(), ch.equipamento.nome
                    );
                }

                Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
                Console.Write(">> Digite o ID do registro que deseja EXCLUIR: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado chamadoSelecionado = chamadosSalvos[i];

                    if (chamadoSelecionado == null)
                    {
                        continue;
                    }

                    if (chamadoSelecionado.id == idSelecionado)
                    {
                        chamadosSalvos[i] = null;
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($">> O chamado foi excluido com sucesso!");
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();

            }
            else if (opcaoMenu == "4")
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═══════════════════════════════╗");
                Console.WriteLine("║    VISUALIZAÇÃO DE CHAMADOS   ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.ResetColor();


                Console.WriteLine(
                    "{0, -7} ║ {1, -15} ║ {2, -30} ║ {3, -17} ║ {4, -15}",
                    "Id", "Título", "Descrição", "Data de Abertura", "Equipamento"
                );

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado ch = chamadosSalvos[i];
                    if (ch == null)
                        continue;


                    Console.WriteLine(
                        "{0, -7} ║ {1, -15} ║ {2, -30} ║ {3, -17} ║ {4, -15}",
                        ch.id, ch.titulo, ch.descricao, ch.dataAbertura.ToShortDateString(), ch.equipamento.nome
                    );
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(">> Digite ENTER para continuar...");
                Console.ResetColor();
                Console.ReadLine();
            }
        }
    }
}

