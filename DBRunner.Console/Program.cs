using System;
using System.ServiceProcess;
using DBRunner.Core;
namespace DBRunner.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DBRunner Console Application\n");
            Console.WriteLine("Iniciando sistema, identificando serviços de bancos de dados...");
            GerenciaServicoDb gerenciaServicoDb = new GerenciaServicoDb();
            gerenciaServicoDb.Iniciar();
            Console.Write("Digite nome do serviço a ser parado:");
            string nome = Console.ReadLine();
            ServiceController servico = gerenciaServicoDb.BuscarServicoNome(nome);
            if (servico == null) { Console.WriteLine("Serviço não encontrado"); }
            else
            {
                gerenciaServicoDb.PararServico(servico);
                gerenciaServicoDb.IniciarServico(servico);
            }
        }
    }
}
