using Microsoft.VisualBasic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // *IMPLEMENTADO!*
            Console.WriteLine("Digite a placa do veículo que será estacionado:");
            string placaveiculo = Console.ReadLine();
            veiculos.Add(placaveiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que será removido:");

            // *IMPLEMENTADO!*
            string placaveiculo = "";
            placaveiculo = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaveiculo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // *IMPLEMENTADO!*
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = (precoInicial + precoPorHora) * horas;

                // *IMPLEMENTADO!*
                veiculos.Remove(placaveiculo);

                Console.WriteLine($"O veículo de placa {placaveiculo} foi removido e o preço que será pago é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos que estão estacionados são:");
                // *IMPLEMENTADO!*
                foreach(string placaveiculos in veiculos)
                {
                    Console.WriteLine(placaveiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados no momento.");
            }
        }
    }
}
