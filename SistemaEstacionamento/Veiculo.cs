using System;

namespace SistemaEstacionamento
{
    internal class Veiculo
    {
        public string Placa { get; private set; }
        public DateTime HoraEntrada { get; private set; }

        public Veiculo(string placa)
        {
            Placa = placa;
            HoraEntrada = DateTime.Now;
        }
    }
}
