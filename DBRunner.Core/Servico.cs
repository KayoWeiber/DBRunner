using System;
using System.ServiceProcess;
using System.Linq;

namespace DBRunner.Core
{

    public class Servico
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }
        public string NomeExibicao { get; set; }
        public string Servidor { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Porta { get; set; }

        public Servico(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }

    public class GerenciaServicoDb
    {

        static private List<string> nome_servicos_bancos = new List<string> { "MYSQL", "MSSQLSERVER", "POSTGRESQL", "ORACLE" };

        private List<ServiceController> services = new List<ServiceController>();

        private ServiceController[] alls_services = ServiceController.GetServices();

        public GerenciaServicoDb()
        {
            // Adiciona os serviços de banco de dados à lista
            AdicionarServicosLista();
        }

        private void AdicionarServicosLista()
        {

            foreach (ServiceController service in alls_services)
            {

                // Verifica se o nome do serviço contém algum dos nomes de serviços de banco de dados
                foreach (string nome_servico in nome_servicos_bancos)
                {
                    if (service.ServiceName != null && service.ServiceName.ToUpper().Contains(nome_servico.ToUpper()))
                    {
                        services.Add(service);
                        break; // Para evitar adicionar o mesmo serviço mais de uma vez
                    }
                }

            }

            if (services != null)
            {
                Console.WriteLine("Foram encontrados os seguintes serviços de banco de dados: ");

                foreach (ServiceController service in services)
                {
                    Console.WriteLine($"Nome: {service.ServiceName}, Estado: {service.Status}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum serviço de banco de dados encontrado!");
            }
        }
        public void Iniciar()
        {
            AdicionarServicosLista();
        }

        public ServiceController BuscarServicoNome(string nome)
        {
            foreach (ServiceController service in services)
            {

                if (service.ServiceName.ToLower().Contains(nome.ToLower()))
                {
                    return service;
                }

            }

            return null;

        }

        public bool PararServico(ServiceController servico)
        {
            if (servico.Status == ServiceControllerStatus.Running)
            {
                Console.WriteLine($"Parando o serviço {servico.ServiceName}...");
                servico.Stop();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IniciarServico(ServiceController servico)
        {
            if (servico.Status != ServiceControllerStatus.Running)
            {
                Console.WriteLine($"Iniciando o serviço {servico.ServiceName}...");
                servico.Start();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
