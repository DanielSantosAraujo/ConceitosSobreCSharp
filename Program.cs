
internal class Program
{
    static void Main(string[] args)
    {
        // AulaClasses();
        // AulaPropriedadeSomenteLeitura();
        // AulaHeranca();
        // AulaClasseSelada();
        // AulaClasseAbstrata();
        // AulaRecord();
        // AulaInterface();
        // TrabalhandoComDatas();
        // TrabalhandoComExcecoes();
        TrabalhandoComLinq();
    }

    private static void TrabalhandoComLinq()
    {
        var trabalhandoComLinq = new Modulo14.TrabalhandoComLinq();
        // trabalhandoComLinq.AulaWhere();
        // trabalhandoComLinq.AulaOrdenacao();
        // trabalhandoComLinq.AulaTake();
        // trabalhandoComLinq.AulaCount();
        trabalhandoComLinq.AulaFirstEFirstOrDefault();
    }

    private static void TrabalhandoComArquivos()
    {
        var trabalhandoComArquivos = new Modulo13.TrabalhancoComArquivo();
        // trabalhandoComArquivos.AulaCriandoArquivo();
        // trabalhandoComArquivos.AulaLendoArquivos();
        trabalhandoComArquivos.AulaExcluindoArquivos();
    }

    private static void TrabalhandoComExcecoes()
    {
        var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
        // trabalhandoComExcecoes.AulaGerandoException();
        trabalhandoComExcecoes.AulaTratandoException();
    }

    private static void TrabalhandoComDatas()
    {
        var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
        // trabalhandoComDatas.AulaDateTime();
        // trabalhandoComDatas.AulaSubtraindoDatas();
        // trabalhandoComDatas.AulaAddDiasMesAno();
        // trabalhandoComDatas.AulaAddHorasMinutosSegundos();
        // trabalhandoComDatas.AulaDiaDaSemana();
        // trabalhandoComDatas.AulaDateOnly();
        trabalhandoComDatas.AulaTimeOnly();
    }

    private static void TrabalhandoComStrings()
    {
        var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
        // trabalhandoComStrings.ConverterParaLetrarMinusculas();
        // trabalhandoComStrings.ConverterParaLetrarMaiusculas();
        // trabalhandoComStrings.AulaSubString();
        // trabalhandoComStrings.AulaRange();
        // trabalhandoComStrings.AulaContains();
        // trabalhandoComStrings.AulaTrim();
        // trabalhandoComStrings.AulaSartsAndEnds();
        // trabalhandoComStrings.AulaReplace();
        trabalhandoComStrings.AulaLength();
    }

    private static void AulaInterface()
    {
        var NotificacaoCliente = new Cadastro.NotificacaoCliente();
        NotificacaoCliente.Notificar();
        NotificacaoCliente.NotificarOutros();

        Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
        notificacao.Notificar();
    }

    private static void AulaRecord()
    {
        // var curso1 = new Cadastro.Curso {Id = 1, Descricao = "Curso"};
        // var curso2 = new Cadastro.Curso {Id = 1, Descricao = "Curso"};

        var curso1 = new Cadastro.Curso(1, "Curso");
        var curso2 = curso1 with { Descricao = "Teste Novo"};

        // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
        // var curso2 = curso1;
        // curso2.Descricao = "Teste Teste";

        
        // var curso2 = new Cadastro.CursoTeste();
        // curso2.Id = curso1.Id;
        // curso2.Descricao = "Nova descrição";

        Console.WriteLine(curso1.Descricao);
        Console.WriteLine(curso2.Descricao);


        // Console.WriteLine(curso1.Equals(curso2));
        // Console.WriteLine(curso1 == curso2);

    }

    private static void AulaClasseAbstrata()
    {
        var cachorro = new Cadastro.Cachorro();
        cachorro.Nome = "Dog";
        cachorro.ImprimirDados();
    }

    private static void AulaClasseSelada()
    {
        var configuracao = new Cadastro.Configuracao
        {
            Host = "localhost"
        };

        Console.WriteLine(configuracao.Host);
    }

    private static void AulaHeranca()
    {
        // var pessoFisica = new Cadastro.PessoFisica();
        // pessoFisica.Id = 1;
        // pessoFisica.Endereco = "Endereço teste";
        // pessoFisica.Cidade = "Cidade teste";
        // pessoFisica.Cep = "123456677";
        // pessoFisica.CPF = "2334556695945";
        // pessoFisica.Imprimirdados();
        // pessoFisica.ImprimirCpf();

        var funcionario = new Cadastro.Funcionario();
        funcionario.Id = 10;
        funcionario.Endereco = "Endereço teste";
        funcionario.Cidade = "Cidade teste";
        funcionario.Cep = "123456677";
        funcionario.CPF = "2334556695945";
        funcionario.Imprimirdados();
        funcionario.ImprimirCpf();
    }



    private static void AulaClasses()
    {
        var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
        Console.WriteLine(resultado);
        // var produto = new Cadastro.Produto();
        // produto.Descricao = "Teclado";
        // produto.SetId(1);
        // produto.ImprimirDescricao();
        // Console.WriteLine(produto.GetId());
    }


    private static void AulaPropriedadeSomenteLeitura()
    {
        var produto = new Cadastro.Produto();
        produto.Descricao = "Mouse";
        // produto.Estoque = 1;
        Console.WriteLine(produto.Estoque);
    }
}