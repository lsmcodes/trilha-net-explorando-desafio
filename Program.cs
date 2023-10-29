using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

bool exibirMenu = true;

while(exibirMenu)
{
    Console.WriteLine("1 - Fazer reserva");
    Console.WriteLine("2 - Sair");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Menu.AdicionarHospedes();
            Menu.AdicionarSuite();
            Menu.FazerReserva();
            Menu.MostrarQuantidadeDeHospedesEValorTotal();
            break;
        case "2":
            exibirMenu = false;
            break;
    }
}