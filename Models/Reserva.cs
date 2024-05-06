using System;
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
       
            if ( DiasReservados >=hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException ("Suite não comporta a quantidade de hospedes informado");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            var retornaQuantidadeHospedes = Hospedes.Count;
            return retornaQuantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            var calculo= DiasReservados * Suite.ValorDiaria;
            decimal valor = calculo;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10)
            {
               var valorComDesconto = (double)DiasReservados * (double)Suite.ValorDiaria * 0.9;
               valor = (decimal)valorComDesconto;
            }

            return valor;
        }
    }
}