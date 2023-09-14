using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Model
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            Console.WriteLine("Digite a placa do veículo para estacionar");
           
           string? placa = Console.ReadLine();
           if(!string.IsNullOrEmpty(placa)) {
                veiculos.Add(placa.ToUpper());
           }else{
            Console.Write("Por favor informar uma placa!");
           }
           
        }

        public void RemoverVeiculo(){
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string? placa = Console.ReadLine();
           
                if (veiculos.Any(x => x.ToUpper()== placa.ToUpper())){
                    Console.WriteLine(" Digite a quantidade horas que o veículo permaneceu estacionado");

                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = PrecoInicial + (PrecoPorHora * horas);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    veiculos.Remove(placa);
                }else{
                    Console.WriteLine("Desculpe, esse veículo bnão está estacionado aqui. Confira se digitou a placa correta.");
                }
            

        }

        public void ListarVeiculos(){
            Console.WriteLine("chamaou");
            if(veiculos.Any()){
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }else{
                Console.WriteLine("Não há veiculos estacionados");
            }
        }
    }
}