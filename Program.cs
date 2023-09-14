using DesafioFundamentos.Model;
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora =0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \n"+
                    "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());
if(precoInicial.Equals(0)){
    Console.WriteLine("Digite o preço inicial:");
    precoInicial = Convert.ToDecimal(Console.ReadLine());
}
Console.WriteLine("Agora digite o preco por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;

bool exiberMenu = true;

while(exiberMenu){
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar Veíciulo");
    Console.WriteLine("2 - Remover Veíciulo");
    Console.WriteLine("3 - Listar Veíciulo");
    Console.WriteLine("4 - Encerrar");
    
    switch(Console.ReadLine()){
        case "1":
        es.AdicionarVeiculo();
        break;
        
        case "2":
        es.RemoverVeiculo();
        break;

        case "3": 
        es.ListarVeiculos();
        break;
        
        case "4":
        exiberMenu = false;
        break;

        default:
        Console.WriteLine("Opção Inválida");
        break;

        
    }
    Console.WriteLine("Pressione uma tecla para continuar"); 
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");