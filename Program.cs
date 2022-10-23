using System.Timers;
using System.Collections.Generic;
using System;

public class Program
{
    public static List<string> lista = new List<string>();
    public static decimal custoEntrada, custoPorHora;
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem Vindo ao nosso sistema de estacionamento!");
        Console.Write($"Digite o valor de entrada: ");
        custoEntrada = decimal.Parse(Console.ReadLine());
        Console.Write($"Digite o valor por hora: ");
        custoPorHora = decimal.Parse(Console.ReadLine());
        Console.Clear();

        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine($"1 - Cadastrar veículo");
        Console.WriteLine($"2 - Remover Veículo");
        Console.WriteLine($"3 - Listar Veículo");
        Console.WriteLine($"4 - Encerrar operação");
        Console.Write($"Digite a sua opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Clear();
                CadastrarVeiculo();
            break;

            case "2":
                Console.Clear();
                RemoverVeiculos();
            break;

            case "3":
                Console.Clear();
                ListarVeiculos();
            break;

            case "4":
                Console.Clear();
                Encerrar();
            break;

            default:
                Console.Clear();
                Console.WriteLine($"Opção incorreta. Tente novamente");
                Menu();
            break;
        }
    }
    public static void CadastrarVeiculo()
    {
        Console.Write("Digite a placa do veículo: ");
        //string placa = Console.ReadLine();
        lista.Add(new(Console.ReadLine().ToUpper()));
        Console.WriteLine($"Veículo adicionado. Pressione qualquer botão para Menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    public static void RemoverVeiculos()
    {
        Console.Write($"Digite a placa do veículo para finalizar: ");
        string placa = Console.ReadLine().ToUpper();

        if(lista.Contains(placa))
        {
            Console.Write($"Digite quantas horas permaneceu estacionado: ");
            int hora = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Custo entrada: {custoEntrada:C2}");
            Console.WriteLine($"Custo por hora: {custoPorHora:C2}");
            Console.WriteLine($"Permanência: {hora}h");
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi {custoPorHora * hora + custoEntrada:C2}");
        }
        else Console.WriteLine($"Não foi possível finalizar veículo {placa}. Tente novamente");
        
        Console.ReadKey();
        Console.Clear();
        Menu();    
    }

    public static void ListarVeiculos()
    {
        if (lista.Any())
        {
            Console.WriteLine($"Veículo listados. Pressione Qualquer botão para Menu");
            foreach (var item in lista)
            {
                Console.WriteLine($"{item}");
            }
        }
        else Console.WriteLine($"Não há veículo estacionado");
        
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    public static void Encerrar()
    {
        Console.WriteLine($"Agradecemos por usar nossos serviços");
        Console.ReadKey();
        Environment.Exit(0);
    }
}