using System;
using System.Collections.Generic;

namespace SistemaEstacionamento
{
    internal class Estacionamento
    {
        private List<Veiculo> veiculosEstacionados;

        public Estacionamento()
        {
            veiculosEstacionados = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculosEstacionados.Add(veiculo);
        }

        public decimal RemoverVeiculo(string placa)
        {
            Veiculo veiculo = veiculosEstacionados.Find(v => v.Placa == placa);
            if (veiculo != null)
            {
                TimeSpan tempoEstacionado = DateTime.Now - veiculo.HoraEntrada;
               
                decimal valorCobrado = (decimal)tempoEstacionado.TotalHours * 2.0M;
                veiculosEstacionados.Remove(veiculo);
                return valorCobrado;
            }
            else
            {
                return -1; 
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (Veiculo veiculo in veiculosEstacionados)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Hora de Entrada: {veiculo.HoraEntrada}");
            }
        }
    }
}
