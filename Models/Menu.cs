namespace DesafioProjetoHospedagem.Models;

public class Menu
{
    public static List<Pessoa> hospedes;
    public static Suite suite;
    public static Reserva reserva;

    public static void AdicionarHospedes()
    {
        hospedes = new List<Pessoa>();
        Console.Clear();
        Console.WriteLine($"Cadastro de hóspedes");
        Console.WriteLine("\nQuantos hóspedes você gostaria de adicionar?");
        int quantidadeHospedes = Convert.ToInt32(Console.ReadLine());

        if(quantidadeHospedes <= 0)
        {
            throw new Exception("A quantidade de hóspedes deve ser maior que 0");
        }

        for(int i = 0; i < quantidadeHospedes; i++)
        {
            Console.Clear();
            Console.WriteLine($"Digite o nome do {i + 1}° hóspede:");
            string nome = Console.ReadLine();

            if(nome.Equals(""))
            {
                hospedes.Add(new());
            }
            else
            {
                Console.WriteLine($"Digite o sobrenome do {i + 1}° hóspede:");
                string sobrenome = Console.ReadLine();
                if(sobrenome.Equals(""))
                {
                    hospedes.Add(new(nome));
                }
                else
                {
                    hospedes.Add(new(nome, sobrenome));
                }
            }
        }
    }

    public static void AdicionarSuite()
    {
        Console.Clear();
        Console.WriteLine($"Escolha da suíte");
        Console.WriteLine($"\nDigite o tipo da suíte:");
        string tipoSuite = Console.ReadLine();

        Console.WriteLine($"Digite a capacidade da suíte:");
        int capacidadeSuite = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Digite o valor da diária:");
        decimal valorDiaria = Convert.ToDecimal(Console.ReadLine());

        if(capacidadeSuite <= 0 || valorDiaria <= 0)
        {
            throw new Exception("A capacidade da suíte e o valor da diária devem ser maiores que 0");
        }

        suite = new Suite(tipoSuite, capacidadeSuite, valorDiaria);
    }

    public static void FazerReserva()
    {
        Console.Clear();
        Console.WriteLine($"Registrando a reserva");

        Console.WriteLine($"\nDigite a quantidade de dias que durará a hospedagem (10 dias ou mais: 10% de desconto):");
        int diasReservados = Convert.ToInt32(Console.ReadLine());

        if(diasReservados <= 0)
        {
            throw new Exception("A quantidade de dias reservados deve ser maior que 0");
        }

        reserva = new Reserva(diasReservados);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);
    }

    public static void MostrarQuantidadeDeHospedesEValorTotal()
    {
        Console.WriteLine($"\nHóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}\n");
    }
}